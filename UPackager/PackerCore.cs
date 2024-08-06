using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace UPackager
{
    internal class PackerCore
    {
        public void GenerateStagingFiles(string DesktopPath, string PackName, string PackVersion, 
            string PackDescription, string PackAssetType, string ClassType, string CategoryName)
        {

            try
            {
                if (!string.IsNullOrEmpty(PackName))
                {
                    // Create Folders/Sub-folders
                    // -----------------------

                    Directory.CreateDirectory($"{DesktopPath}\\{PackName}\\");
                    Directory.CreateDirectory($"{DesktopPath}\\{PackName}\\ContentSettings\\Config\\");
                    Directory.CreateDirectory($"{DesktopPath}\\{PackName}\\ContentSettings\\Media\\");
                    Directory.CreateDirectory($"{DesktopPath}\\{PackName}\\FeaturePacks\\");
                    Directory.CreateDirectory($"{DesktopPath}\\{PackName}\\Samples\\{PackName}\\Content\\{PackName}\\");

                    // Create Files
                    // -----------------------

                    // ContentToPack.txt
                    File.WriteAllText($"{DesktopPath}\\{PackName}\\ContentToPack.txt", 
                        $"\"{DesktopPath}\\{PackName}\\ContentSettings\\Config\\\"\n" +
                        $"\"{DesktopPath}\\{PackName}\\ContentSettings\\Media\\\"\n" +
                        $"\"{DesktopPath}\\{PackName}\\ContentSettings\\manifest.json\"");

                    // config.ini
                    File.WriteAllText($"{DesktopPath}\\{PackName}\\ContentSettings\\Config\\config.ini", 
                        $"[AdditionalFilesToAdd]\r\n+Files=Samples\\{PackName}\\Content\\*.*");

                    // Create manifest.json (Works Now)
                    CreateManifest(DesktopPath, PackName, PackVersion, 
                        PackDescription, PackAssetType, ClassType, CategoryName);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        void CreateManifest(string DesktopPath, string PackName, string PackVersion, 
            string PackDescription, string PackAssetType, string ClassType, string CategoryName)
        {
            try
            {
                var manifest = new
                {
                    Version = 1,
                    Name = new[] { new { Language = "en", Text = PackName } },
                    Description = new[] { new { Language = "en", Text = PackDescription } },
                    AssetTypes = string.IsNullOrEmpty(PackAssetType) ? new object[0] : new[] { new { Language = "en", Text = PackAssetType } },
                    SearchTags = new[] { new { Language = "en", Text = PackName } },
                    ClassTypes = "",
                    Category = string.IsNullOrEmpty(CategoryName) ? "Content" : CategoryName,
                    Thumbnail = $"{PackName}.png",
                    Screenshots = new[] { $"{PackName}_Preview.png" }
                };

                string jsonString = JsonConvert.SerializeObject(manifest, Formatting.Indented);

                string manifestPath = Path.Combine(DesktopPath, PackName, "ContentSettings", "manifest.json");
                File.WriteAllText(manifestPath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void GenerateBatchFiles(string DesktopPath, string EnginePath, string PackName)
        {
            try
            {
                if (!string.IsNullOrEmpty(EnginePath))
                {
                    // Pack.bat
                    string PackBatch = $"\"{EnginePath}\\Engine\\Binaries\\Win64\\UnrealPak.exe\" " +
                        $"-Create=\"{DesktopPath}\\{PackName}\\ContentToPack.txt\" " +
                        $"\"{DesktopPath}\\{PackName}\\FeaturePacks\\{PackName}.upack\"";
                    string PackBatchCommand = $"@echo off\n{PackBatch} %USERPROFILE%\n";
                    
                    File.WriteAllText($"{DesktopPath}\\{PackName}\\Pack.bat", PackBatchCommand);
                }

                else
                {
                    MessageBox.Show("Error: Missing Engine Path", "Engine Path");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        public void CopyFilesAndRootFolder(string sourceDirectory, string destinationDirectory, bool CopyRoot)
        {
            try
            {
                if (CopyRoot)
                {
                    // Create the destination directory if it doesn't exist
                    Directory.CreateDirectory(destinationDirectory);

                    // Get the name of the source folder
                    string sourceFolderName = new DirectoryInfo(sourceDirectory).Name;

                    // Create the root folder in the destination
                    string destinationRoot = Path.Combine(destinationDirectory, sourceFolderName);
                    Directory.CreateDirectory(destinationRoot);

                    // Copy all files from the source to the destination root folder
                    foreach (string file in Directory.GetFiles(sourceDirectory))
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(destinationRoot, fileName);
                        File.Copy(file, destFile, true);
                    }
                }

                else
                {
                    if (!Directory.Exists(destinationDirectory))
                    {
                        // Create the destination directory if it doesn't exist
                        Directory.CreateDirectory(destinationDirectory);
                    }

                    // Copy all files from the source to the destination folder
                    foreach (string file in Directory.GetFiles(sourceDirectory))
                    {
                        string fileName = Path.GetFileName(file);
                        string destFile = Path.Combine(destinationDirectory, fileName);
                        File.Copy(file, destFile, true);
                    }

                    // Copy all subdirectories and their contents
                    foreach (string dir in Directory.GetDirectories(sourceDirectory, "*", SearchOption.AllDirectories))
                    {
                        string dirToCreate = dir.Replace(sourceDirectory, destinationDirectory);
                        Directory.CreateDirectory(dirToCreate);

                        foreach (string file in Directory.GetFiles(dir))
                        {
                            string fileName = Path.GetFileName(file);
                            string destFile = Path.Combine(dirToCreate, fileName);
                            File.Copy(file, destFile, true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public async Task RunProcessAsync(TextBox TextBox, bool AutoClose, string FullPath, Form form)
        {
            // Clear the Text box when ever this block is called.
            TextBox.Clear();

            // Start the process
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                // {FullPath}\\Batch\\Pack.bat
                FileName = FullPath + "Pack.bat",
                UseShellExecute = true,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = processInfo })
            {
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardInput = true;
                process.StartInfo.UseShellExecute = false;
                process.OutputDataReceived += (sender, e) =>
                {
                    StringBuilder output = new StringBuilder();

                    if (e.Data != null)
                    {
                        // Append the output to our StringBuilder
                        output.AppendLine(e.Data);

                        // Update the TextBlock on the UI thread
                        form.Invoke((MethodInvoker)delegate {
                            TextBox.Text = output.ToString();
                        });

                        if (e.Data.Contains("Press Enter to continue"))
                        {
                            process.StandardInput.WriteLine();
                        }
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                // process.BeginErrorReadLine();

                if (AutoClose == true)
                {
                    form.Close();
                }

                await Task.Run(() => process.WaitForExit());
            }
        }

        public void CopyImagesOver(string sourceDir, string PackName, string IconPath, string PreviewPath)
        {
            try
            {
                string destinationFolder = $"{sourceDir}\\{PackName}\\ContentSettings\\Media";

                if (!File.Exists(destinationFolder))
                {

                    string IconName = new DirectoryInfo(destinationFolder).Name;
                    string IconDestination = Path.Combine(destinationFolder, $"{PackName}.png");
                    File.Copy(IconPath, IconDestination, true);

                    string folderName = new DirectoryInfo(destinationFolder).Name;
                    string PreviewDestination = Path.Combine(destinationFolder, $"{PackName}_Preview.png");
                    File.Copy(PreviewPath, PreviewDestination, true);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }

}
