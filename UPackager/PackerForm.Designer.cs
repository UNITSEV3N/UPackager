namespace UPackager
{
    partial class PackerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackerForm));
            this.TXTBOX_PackName = new System.Windows.Forms.TextBox();
            this.TXTBOX_Description = new System.Windows.Forms.TextBox();
            this.TXTBOX_AssetTypes = new System.Windows.Forms.TextBox();
            this.TXTBOX_Category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTBOX_EnginePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTBOX_ContentPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_Stage = new System.Windows.Forms.Button();
            this.TXTBOX_Ver = new System.Windows.Forms.TextBox();
            this.TXTBOX_CMD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_FindContentPath = new System.Windows.Forms.Button();
            this.BTN_FindEnginePath = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PICBOX_Icon = new System.Windows.Forms.PictureBox();
            this.PICBOX_Preview = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTN_PACK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CB_AutoOpenStagingFolder = new System.Windows.Forms.CheckBox();
            this.CB_CloseOnPack = new System.Windows.Forms.CheckBox();
            this.CB_OnTop = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Preview)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTBOX_PackName
            // 
            this.TXTBOX_PackName.AcceptsReturn = true;
            this.TXTBOX_PackName.Location = new System.Drawing.Point(77, 13);
            this.TXTBOX_PackName.MaxLength = 27;
            this.TXTBOX_PackName.Name = "TXTBOX_PackName";
            this.TXTBOX_PackName.Size = new System.Drawing.Size(284, 20);
            this.TXTBOX_PackName.TabIndex = 1;
            this.TXTBOX_PackName.TabStop = false;
            // 
            // TXTBOX_Description
            // 
            this.TXTBOX_Description.AcceptsReturn = true;
            this.TXTBOX_Description.Location = new System.Drawing.Point(77, 59);
            this.TXTBOX_Description.Multiline = true;
            this.TXTBOX_Description.Name = "TXTBOX_Description";
            this.TXTBOX_Description.Size = new System.Drawing.Size(332, 57);
            this.TXTBOX_Description.TabIndex = 3;
            this.TXTBOX_Description.TabStop = false;
            // 
            // TXTBOX_AssetTypes
            // 
            this.TXTBOX_AssetTypes.AcceptsReturn = true;
            this.TXTBOX_AssetTypes.Location = new System.Drawing.Point(77, 119);
            this.TXTBOX_AssetTypes.Multiline = true;
            this.TXTBOX_AssetTypes.Name = "TXTBOX_AssetTypes";
            this.TXTBOX_AssetTypes.Size = new System.Drawing.Size(332, 57);
            this.TXTBOX_AssetTypes.TabIndex = 4;
            this.TXTBOX_AssetTypes.TabStop = false;
            // 
            // TXTBOX_Category
            // 
            this.TXTBOX_Category.AcceptsReturn = true;
            this.TXTBOX_Category.Location = new System.Drawing.Point(77, 36);
            this.TXTBOX_Category.Name = "TXTBOX_Category";
            this.TXTBOX_Category.Size = new System.Drawing.Size(332, 20);
            this.TXTBOX_Category.TabIndex = 2;
            this.TXTBOX_Category.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pack Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asset Types";
            // 
            // TXTBOX_EnginePath
            // 
            this.TXTBOX_EnginePath.AcceptsReturn = true;
            this.TXTBOX_EnginePath.AllowDrop = true;
            this.TXTBOX_EnginePath.Location = new System.Drawing.Point(77, 13);
            this.TXTBOX_EnginePath.Name = "TXTBOX_EnginePath";
            this.TXTBOX_EnginePath.Size = new System.Drawing.Size(304, 20);
            this.TXTBOX_EnginePath.TabIndex = 8;
            this.TXTBOX_EnginePath.TabStop = false;
            this.TXTBOX_EnginePath.TextChanged += new System.EventHandler(this.TXTBOX_EnginePath_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Engine Path";
            // 
            // TXTBOX_ContentPath
            // 
            this.TXTBOX_ContentPath.AcceptsReturn = true;
            this.TXTBOX_ContentPath.AllowDrop = true;
            this.TXTBOX_ContentPath.Location = new System.Drawing.Point(77, 42);
            this.TXTBOX_ContentPath.Name = "TXTBOX_ContentPath";
            this.TXTBOX_ContentPath.Size = new System.Drawing.Size(304, 20);
            this.TXTBOX_ContentPath.TabIndex = 10;
            this.TXTBOX_ContentPath.TabStop = false;
            this.TXTBOX_ContentPath.TextChanged += new System.EventHandler(this.TXTBOX_ContentPath_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Content Path";
            // 
            // BTN_Stage
            // 
            this.BTN_Stage.Location = new System.Drawing.Point(12, 435);
            this.BTN_Stage.Name = "BTN_Stage";
            this.BTN_Stage.Size = new System.Drawing.Size(420, 23);
            this.BTN_Stage.TabIndex = 12;
            this.BTN_Stage.TabStop = false;
            this.BTN_Stage.Text = "STAGE";
            this.BTN_Stage.UseVisualStyleBackColor = true;
            this.BTN_Stage.Click += new System.EventHandler(this.BTN_Stage_Click);
            // 
            // TXTBOX_Ver
            // 
            this.TXTBOX_Ver.Location = new System.Drawing.Point(367, 13);
            this.TXTBOX_Ver.Name = "TXTBOX_Ver";
            this.TXTBOX_Ver.Size = new System.Drawing.Size(42, 20);
            this.TXTBOX_Ver.TabIndex = 13;
            this.TXTBOX_Ver.TabStop = false;
            this.TXTBOX_Ver.Text = "1";
            this.TXTBOX_Ver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXTBOX_CMD
            // 
            this.TXTBOX_CMD.Location = new System.Drawing.Point(12, 493);
            this.TXTBOX_CMD.Multiline = true;
            this.TXTBOX_CMD.Name = "TXTBOX_CMD";
            this.TXTBOX_CMD.ReadOnly = true;
            this.TXTBOX_CMD.Size = new System.Drawing.Size(420, 65);
            this.TXTBOX_CMD.TabIndex = 100;
            this.TXTBOX_CMD.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXTBOX_PackName);
            this.groupBox1.Controls.Add(this.TXTBOX_Ver);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TXTBOX_Category);
            this.groupBox1.Controls.Add(this.TXTBOX_Description);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TXTBOX_AssetTypes);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 183);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TXTBOX_EnginePath);
            this.groupBox2.Controls.Add(this.TXTBOX_ContentPath);
            this.groupBox2.Controls.Add(this.BTN_FindContentPath);
            this.groupBox2.Controls.Add(this.BTN_FindEnginePath);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 75);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // BTN_FindContentPath
            // 
            this.BTN_FindContentPath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_FindContentPath.BackgroundImage")));
            this.BTN_FindContentPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_FindContentPath.Location = new System.Drawing.Point(387, 40);
            this.BTN_FindContentPath.Name = "BTN_FindContentPath";
            this.BTN_FindContentPath.Size = new System.Drawing.Size(27, 23);
            this.BTN_FindContentPath.TabIndex = 11;
            this.BTN_FindContentPath.TabStop = false;
            this.BTN_FindContentPath.UseVisualStyleBackColor = true;
            this.BTN_FindContentPath.Click += new System.EventHandler(this.BTN_FindContentPath_Click);
            // 
            // BTN_FindEnginePath
            // 
            this.BTN_FindEnginePath.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_FindEnginePath.BackgroundImage")));
            this.BTN_FindEnginePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTN_FindEnginePath.Location = new System.Drawing.Point(387, 11);
            this.BTN_FindEnginePath.Name = "BTN_FindEnginePath";
            this.BTN_FindEnginePath.Size = new System.Drawing.Size(27, 23);
            this.BTN_FindEnginePath.TabIndex = 9;
            this.BTN_FindEnginePath.TabStop = false;
            this.BTN_FindEnginePath.UseVisualStyleBackColor = true;
            this.BTN_FindEnginePath.Click += new System.EventHandler(this.BTN_FindEnginePath_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.PICBOX_Icon);
            this.groupBox3.Controls.Add(this.PICBOX_Preview);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 146);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "PREVIEW 400 X 200";
            // 
            // PICBOX_Icon
            // 
            this.PICBOX_Icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PICBOX_Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICBOX_Icon.Image = global::UPackager.Properties.Resources.Icon_Default;
            this.PICBOX_Icon.Location = new System.Drawing.Point(9, 32);
            this.PICBOX_Icon.Name = "PICBOX_Icon";
            this.PICBOX_Icon.Size = new System.Drawing.Size(112, 107);
            this.PICBOX_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_Icon.TabIndex = 17;
            this.PICBOX_Icon.TabStop = false;
            this.PICBOX_Icon.Click += new System.EventHandler(this.PICBOX_Icon_Click);
            // 
            // PICBOX_Preview
            // 
            this.PICBOX_Preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PICBOX_Preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PICBOX_Preview.Image = global::UPackager.Properties.Resources.Preview_Default;
            this.PICBOX_Preview.Location = new System.Drawing.Point(150, 32);
            this.PICBOX_Preview.Name = "PICBOX_Preview";
            this.PICBOX_Preview.Size = new System.Drawing.Size(259, 107);
            this.PICBOX_Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PICBOX_Preview.TabIndex = 18;
            this.PICBOX_Preview.TabStop = false;
            this.PICBOX_Preview.Click += new System.EventHandler(this.PICBOX_Preview_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ICON 64 X 64";
            // 
            // BTN_PACK
            // 
            this.BTN_PACK.Location = new System.Drawing.Point(12, 464);
            this.BTN_PACK.Name = "BTN_PACK";
            this.BTN_PACK.Size = new System.Drawing.Size(420, 23);
            this.BTN_PACK.TabIndex = 14;
            this.BTN_PACK.Text = "PACK";
            this.BTN_PACK.UseVisualStyleBackColor = true;
            this.BTN_PACK.Click += new System.EventHandler(this.BTN_PACK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CB_AutoOpenStagingFolder);
            this.groupBox4.Controls.Add(this.CB_CloseOnPack);
            this.groupBox4.Controls.Add(this.CB_OnTop);
            this.groupBox4.Location = new System.Drawing.Point(439, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 546);
            this.groupBox4.TabIndex = 101;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Settings";
            // 
            // CB_AutoOpenStagingFolder
            // 
            this.CB_AutoOpenStagingFolder.AutoSize = true;
            this.CB_AutoOpenStagingFolder.Location = new System.Drawing.Point(6, 40);
            this.CB_AutoOpenStagingFolder.Name = "CB_AutoOpenStagingFolder";
            this.CB_AutoOpenStagingFolder.Size = new System.Drawing.Size(91, 17);
            this.CB_AutoOpenStagingFolder.TabIndex = 3;
            this.CB_AutoOpenStagingFolder.TabStop = false;
            this.CB_AutoOpenStagingFolder.Text = "Open Staging";
            this.CB_AutoOpenStagingFolder.UseVisualStyleBackColor = true;
            this.CB_AutoOpenStagingFolder.CheckedChanged += new System.EventHandler(this.CB_AutoOpenStagingFolder_CheckedChanged);
            // 
            // CB_CloseOnPack
            // 
            this.CB_CloseOnPack.AutoSize = true;
            this.CB_CloseOnPack.Location = new System.Drawing.Point(101, 40);
            this.CB_CloseOnPack.Name = "CB_CloseOnPack";
            this.CB_CloseOnPack.Size = new System.Drawing.Size(95, 17);
            this.CB_CloseOnPack.TabIndex = 2;
            this.CB_CloseOnPack.TabStop = false;
            this.CB_CloseOnPack.Text = "Close on Pack";
            this.CB_CloseOnPack.UseVisualStyleBackColor = true;
            this.CB_CloseOnPack.CheckedChanged += new System.EventHandler(this.CB_CloseOnPack_CheckedChanged);
            // 
            // CB_OnTop
            // 
            this.CB_OnTop.AutoSize = true;
            this.CB_OnTop.Location = new System.Drawing.Point(6, 19);
            this.CB_OnTop.Name = "CB_OnTop";
            this.CB_OnTop.Size = new System.Drawing.Size(62, 17);
            this.CB_OnTop.TabIndex = 0;
            this.CB_OnTop.TabStop = false;
            this.CB_OnTop.Text = "On Top";
            this.CB_OnTop.UseVisualStyleBackColor = true;
            this.CB_OnTop.CheckedChanged += new System.EventHandler(this.CB_OnTop_CheckedChanged);
            // 
            // PackerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 567);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BTN_PACK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TXTBOX_CMD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BTN_Stage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackerForm";
            this.Text = "UPackager";
            this.Load += new System.EventHandler(this.PackerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PICBOX_Preview)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTBOX_PackName;
        private System.Windows.Forms.TextBox TXTBOX_Description;
        private System.Windows.Forms.TextBox TXTBOX_AssetTypes;
        private System.Windows.Forms.TextBox TXTBOX_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTBOX_EnginePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTBOX_ContentPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_Stage;
        private System.Windows.Forms.TextBox TXTBOX_Ver;
        private System.Windows.Forms.TextBox TXTBOX_CMD;
        private System.Windows.Forms.Button BTN_FindEnginePath;
        private System.Windows.Forms.Button BTN_FindContentPath;
        private System.Windows.Forms.PictureBox PICBOX_Icon;
        private System.Windows.Forms.PictureBox PICBOX_Preview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BTN_PACK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox CB_OnTop;
        private System.Windows.Forms.CheckBox CB_CloseOnPack;
        private System.Windows.Forms.CheckBox CB_AutoOpenStagingFolder;
    }
}

