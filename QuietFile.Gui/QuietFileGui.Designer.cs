namespace QuietFile.Gui
{
    partial class QuietFileGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuietFileGui));
            this.lbl_SrcPath = new System.Windows.Forms.Label();
            this.txt_SourcePath = new System.Windows.Forms.TextBox();
            this.btn_ChooseLocalSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DestinationDirectory = new System.Windows.Forms.TextBox();
            this.btn_SelectDestinationDirectory = new System.Windows.Forms.Button();
            this.txt_FileNameOverride = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk_OverwriteSource = new System.Windows.Forms.CheckBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.chk_OverwriteDestinationFile = new System.Windows.Forms.CheckBox();
            this.chk_CloseAfterSuccess = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_SrcPath
            // 
            this.lbl_SrcPath.AutoSize = true;
            this.lbl_SrcPath.Location = new System.Drawing.Point(12, 15);
            this.lbl_SrcPath.Name = "lbl_SrcPath";
            this.lbl_SrcPath.Size = new System.Drawing.Size(65, 13);
            this.lbl_SrcPath.TabIndex = 0;
            this.lbl_SrcPath.Text = "Source path";
            // 
            // txt_SourcePath
            // 
            this.txt_SourcePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SourcePath.Location = new System.Drawing.Point(108, 12);
            this.txt_SourcePath.Name = "txt_SourcePath";
            this.txt_SourcePath.Size = new System.Drawing.Size(429, 20);
            this.txt_SourcePath.TabIndex = 1;
            // 
            // btn_ChooseLocalSource
            // 
            this.btn_ChooseLocalSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ChooseLocalSource.Location = new System.Drawing.Point(543, 10);
            this.btn_ChooseLocalSource.Name = "btn_ChooseLocalSource";
            this.btn_ChooseLocalSource.Size = new System.Drawing.Size(29, 23);
            this.btn_ChooseLocalSource.TabIndex = 2;
            this.btn_ChooseLocalSource.Text = "...";
            this.btn_ChooseLocalSource.UseVisualStyleBackColor = true;
            this.btn_ChooseLocalSource.Click += new System.EventHandler(this.btn_ChooseLocalSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Destination folder";
            // 
            // txt_DestinationDirectory
            // 
            this.txt_DestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DestinationDirectory.Location = new System.Drawing.Point(108, 38);
            this.txt_DestinationDirectory.Name = "txt_DestinationDirectory";
            this.txt_DestinationDirectory.Size = new System.Drawing.Size(429, 20);
            this.txt_DestinationDirectory.TabIndex = 4;
            // 
            // btn_SelectDestinationDirectory
            // 
            this.btn_SelectDestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SelectDestinationDirectory.Location = new System.Drawing.Point(543, 36);
            this.btn_SelectDestinationDirectory.Name = "btn_SelectDestinationDirectory";
            this.btn_SelectDestinationDirectory.Size = new System.Drawing.Size(29, 23);
            this.btn_SelectDestinationDirectory.TabIndex = 5;
            this.btn_SelectDestinationDirectory.Text = "...";
            this.btn_SelectDestinationDirectory.UseVisualStyleBackColor = true;
            this.btn_SelectDestinationDirectory.Click += new System.EventHandler(this.btn_SelectDestinationDirectory_Click);
            // 
            // txt_FileNameOverride
            // 
            this.txt_FileNameOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileNameOverride.Location = new System.Drawing.Point(108, 64);
            this.txt_FileNameOverride.Name = "txt_FileNameOverride";
            this.txt_FileNameOverride.Size = new System.Drawing.Size(464, 20);
            this.txt_FileNameOverride.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filename override";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chk_OverwriteSource);
            this.panel1.Controls.Add(this.btn_Start);
            this.panel1.Controls.Add(this.chk_OverwriteDestinationFile);
            this.panel1.Controls.Add(this.chk_CloseAfterSuccess);
            this.panel1.Controls.Add(this.lbl_SrcPath);
            this.panel1.Controls.Add(this.btn_SelectDestinationDirectory);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_ChooseLocalSource);
            this.panel1.Controls.Add(this.txt_SourcePath);
            this.panel1.Controls.Add(this.txt_FileNameOverride);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_DestinationDirectory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 120);
            this.panel1.TabIndex = 8;
            // 
            // chk_OverwriteSource
            // 
            this.chk_OverwriteSource.AutoSize = true;
            this.chk_OverwriteSource.Location = new System.Drawing.Point(108, 94);
            this.chk_OverwriteSource.Name = "chk_OverwriteSource";
            this.chk_OverwriteSource.Size = new System.Drawing.Size(128, 17);
            this.chk_OverwriteSource.TabIndex = 9;
            this.chk_OverwriteSource.Text = "Move instead of copy";
            this.chk_OverwriteSource.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Start.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_Start.Enabled = false;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Start.Location = new System.Drawing.Point(497, 90);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 8;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // chk_OverwriteDestinationFile
            // 
            this.chk_OverwriteDestinationFile.AutoSize = true;
            this.chk_OverwriteDestinationFile.Location = new System.Drawing.Point(242, 94);
            this.chk_OverwriteDestinationFile.Name = "chk_OverwriteDestinationFile";
            this.chk_OverwriteDestinationFile.Size = new System.Drawing.Size(125, 17);
            this.chk_OverwriteDestinationFile.TabIndex = 1;
            this.chk_OverwriteDestinationFile.Text = "Overwrite destination";
            this.chk_OverwriteDestinationFile.UseVisualStyleBackColor = true;
            // 
            // chk_CloseAfterSuccess
            // 
            this.chk_CloseAfterSuccess.AutoSize = true;
            this.chk_CloseAfterSuccess.Location = new System.Drawing.Point(373, 94);
            this.chk_CloseAfterSuccess.Name = "chk_CloseAfterSuccess";
            this.chk_CloseAfterSuccess.Size = new System.Drawing.Size(118, 17);
            this.chk_CloseAfterSuccess.TabIndex = 2;
            this.chk_CloseAfterSuccess.Text = "Close after success";
            this.chk_CloseAfterSuccess.UseVisualStyleBackColor = true;
            // 
            // QuietFileGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 120);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(6000, 158);
            this.MinimumSize = new System.Drawing.Size(600, 158);
            this.Name = "QuietFileGui";
            this.Text = "QuietFile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_SrcPath;
        private System.Windows.Forms.TextBox txt_SourcePath;
        private System.Windows.Forms.Button btn_ChooseLocalSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DestinationDirectory;
        private System.Windows.Forms.Button btn_SelectDestinationDirectory;
        private System.Windows.Forms.TextBox txt_FileNameOverride;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk_CloseAfterSuccess;
        private System.Windows.Forms.CheckBox chk_OverwriteDestinationFile;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.CheckBox chk_OverwriteSource;
    }
}

