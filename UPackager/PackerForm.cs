using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace UPackager
{
    public partial class PackerForm : Form
    {
        // ------------------------------------------------------------------------------ //

        // Packer Backend
        PackerCore packerCore;
        
        // Pack Details - Default Values
        private string PackName = "ContentPack";
        private string PackVersion = "1";
        private string PackDescription = "This is a Content Pack";
        private string PackAssetType;
        private string ClassTypes;
        private string CategoryName;

        // Paths
        private string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string EnginePath;
        string ContentPath;
        string IconPath;
        string PreviewPath;
        string FullPath;

        // Settings
        private bool AutoClose = false;
        private bool OpenStagingFolder = false;
        private bool AlwayOnTop = false;
        private bool CopyRoot = false;
        private bool CloseOnPack = false;

        // ------------------------------------------------------------------------------ //

        public PackerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            packerCore = new PackerCore();
            FullPath = Path.Combine(DesktopPath, PackName);
            BTN_PACK.Enabled = false;
        }

        private void BTN_Stage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(EnginePath) && !string.IsNullOrEmpty(ContentPath))
                {
                    // string fileName = Path.GetFileName(file).Replace(' ', '_');
                    // string destFile = Path.Combine(destinationDirectory, fileName);

                    // Set Values
                    EnginePath = TXTBOX_EnginePath.Text;
                    ContentPath = TXTBOX_ContentPath.Text;
                    PackAssetType = TXTBOX_AssetTypes.Text;
                    PackDescription = TXTBOX_Description.Text;
                    PackVersion = TXTBOX_Ver.Text;
                    PackName = TXTBOX_PackName.Text;
                    CategoryName = TXTBOX_Category.Text;

                    packerCore.GenerateStagingFiles(DesktopPath, PackName, PackVersion, 
                        PackDescription, PackAssetType, ClassTypes, CategoryName);
                    packerCore.GenerateBatchFiles(DesktopPath, 
                        EnginePath, PackName);
                    packerCore.CopyFilesAndRootFolder(ContentPath, 
                        $"{DesktopPath}\\{PackName}\\Samples\\{PackName}\\Content\\", 
                        CopyRoot, PackName);

                    packerCore.CopyImagesOver(DesktopPath, PackName, IconPath, PreviewPath);

                    if (!string.IsNullOrEmpty(PackName))
                    {
                        BTN_PACK.Enabled = true;
                    }

                    if (OpenStagingFolder)
                    {
                        Process.Start("explorer.exe", $"{DesktopPath}\\{PackName}\\");
                    }

                    TXTBOX_CMD.Text = "Copy Complete";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Pack Name is Null");
            }
        }

        private void BTN_FindEnginePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TXTBOX_EnginePath.Text = openFileDialog.SelectedPath;
                    EnginePath = openFileDialog.SelectedPath;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }

            }
        }

        private void BTN_FindContentPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TXTBOX_ContentPath.Text = openFileDialog.SelectedPath;
                    ContentPath = openFileDialog.SelectedPath;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }

            }
        }
        private void PICBOX_Icon_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(FullPath))
            {
                // Create and configure the OpenFileDialog
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image";
                    openFileDialog.Filter = "Image Files|*.png;";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            IconPath = openFileDialog.FileName;
                            PICBOX_Icon.Image = Image.FromFile(IconPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void PICBOX_Preview_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(FullPath))
            {
                // Create and configure the OpenFileDialog
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select an Image";
                    openFileDialog.Filter = "Image Files|*.png;";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            PreviewPath = openFileDialog.FileName;
                            PICBOX_Preview.Image = Image.FromFile(PreviewPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message);
                        }
                    }
                }
            }
        }

        private async void BTN_PACK_Click(object sender, EventArgs e)
        {
            await packerCore.RunProcessAsync(TXTBOX_CMD, AutoClose, $"{DesktopPath}\\{PackName}\\", this);

            if (CloseOnPack)
            {
                this.Close();
            }
        }

        private void TXTBOX_EnginePath_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Engine = TXTBOX_EnginePath.Text;
            Properties.Settings.Default.Save();
        }

        private void TXTBOX_ContentPath_TextChanged(object sender, EventArgs e)
        {
            // Properties.Settings.Default.Content = TXTBOX_ContentPath.Text;
            // Properties.Settings.Default.Save();
        }

        private void PackerForm_Load(object sender, EventArgs e)
        {
            TXTBOX_EnginePath.Text = Properties.Settings.Default.Engine;
            // TXTBOX_ContentPath.Text = Properties.Settings.Default.Content;
            EnginePath = Properties.Settings.Default.Engine;
            // ContentPath = Properties.Settings.Default.Content;
        }

        private void CB_OnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_OnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void CB_CloseOnPack_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_CloseOnPack.Checked == true)
            {
                CloseOnPack = true;
            }
            else
            {
                CloseOnPack = false;
            }
        }

        private void CB_AutoOpenStagingFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_AutoOpenStagingFolder.Checked == true)
            {
                OpenStagingFolder = true;
            }
            else
            {
                OpenStagingFolder = false;
            }
        }

    }
}
