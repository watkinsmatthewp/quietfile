namespace QuietFile
{
    partial class QuietFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuietFile));
            this.txt_SrcFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DestDirectory = new System.Windows.Forms.TextBox();
            this.txt_FileNameOverride = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQuietFile = new System.Windows.Forms.Button();
            this.chk_CloseAfterSuccess = new System.Windows.Forms.CheckBox();
            this.btn_SelectSrcFilePath = new System.Windows.Forms.Button();
            this.btn_SelectDestDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_SrcFilePath
            // 
            this.txt_SrcFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SrcFilePath.Location = new System.Drawing.Point(108, 6);
            this.txt_SrcFilePath.Name = "txt_SrcFilePath";
            this.txt_SrcFilePath.Size = new System.Drawing.Size(280, 20);
            this.txt_SrcFilePath.TabIndex = 0;
            this.txt_SrcFilePath.TextChanged += new System.EventHandler(this.txt_SrcFilePath_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Path";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dest. Dir";
            // 
            // txt_DestDirectory
            // 
            this.txt_DestDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DestDirectory.Location = new System.Drawing.Point(108, 32);
            this.txt_DestDirectory.Name = "txt_DestDirectory";
            this.txt_DestDirectory.Size = new System.Drawing.Size(280, 20);
            this.txt_DestDirectory.TabIndex = 3;
            this.txt_DestDirectory.TextChanged += new System.EventHandler(this.txt_DestDirectory_TextChanged);
            // 
            // txt_FileNameOverride
            // 
            this.txt_FileNameOverride.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FileNameOverride.Location = new System.Drawing.Point(108, 58);
            this.txt_FileNameOverride.Name = "txt_FileNameOverride";
            this.txt_FileNameOverride.Size = new System.Drawing.Size(318, 20);
            this.txt_FileNameOverride.TabIndex = 4;
            this.txt_FileNameOverride.TextChanged += new System.EventHandler(this.txt_FileNameOverride_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filename override";
            // 
            // btnQuietFile
            // 
            this.btnQuietFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuietFile.Location = new System.Drawing.Point(351, 84);
            this.btnQuietFile.Name = "btnQuietFile";
            this.btnQuietFile.Size = new System.Drawing.Size(75, 23);
            this.btnQuietFile.TabIndex = 6;
            this.btnQuietFile.Text = "Get File";
            this.btnQuietFile.UseVisualStyleBackColor = true;
            this.btnQuietFile.Click += new System.EventHandler(this.btnQuietFile_Click);
            // 
            // chk_CloseAfterSuccess
            // 
            this.chk_CloseAfterSuccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chk_CloseAfterSuccess.AutoSize = true;
            this.chk_CloseAfterSuccess.Location = new System.Drawing.Point(108, 88);
            this.chk_CloseAfterSuccess.Name = "chk_CloseAfterSuccess";
            this.chk_CloseAfterSuccess.Size = new System.Drawing.Size(155, 17);
            this.chk_CloseAfterSuccess.TabIndex = 7;
            this.chk_CloseAfterSuccess.Text = "Close after successful copy";
            this.chk_CloseAfterSuccess.UseVisualStyleBackColor = true;
            // 
            // btn_SelectSrcFilePath
            // 
            this.btn_SelectSrcFilePath.Location = new System.Drawing.Point(394, 4);
            this.btn_SelectSrcFilePath.Name = "btn_SelectSrcFilePath";
            this.btn_SelectSrcFilePath.Size = new System.Drawing.Size(32, 23);
            this.btn_SelectSrcFilePath.TabIndex = 8;
            this.btn_SelectSrcFilePath.Text = "...";
            this.btn_SelectSrcFilePath.UseVisualStyleBackColor = true;
            this.btn_SelectSrcFilePath.Click += new System.EventHandler(this.btn_SelectSrcFilePath_Click);
            // 
            // btn_SelectDestDir
            // 
            this.btn_SelectDestDir.Location = new System.Drawing.Point(394, 30);
            this.btn_SelectDestDir.Name = "btn_SelectDestDir";
            this.btn_SelectDestDir.Size = new System.Drawing.Size(32, 23);
            this.btn_SelectDestDir.TabIndex = 9;
            this.btn_SelectDestDir.Text = "...";
            this.btn_SelectDestDir.UseVisualStyleBackColor = true;
            this.btn_SelectDestDir.Click += new System.EventHandler(this.btn_SelectDestDir_Click);
            // 
            // QuietFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 112);
            this.Controls.Add(this.btn_SelectDestDir);
            this.Controls.Add(this.btn_SelectSrcFilePath);
            this.Controls.Add(this.btnQuietFile);
            this.Controls.Add(this.chk_CloseAfterSuccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FileNameOverride);
            this.Controls.Add(this.txt_DestDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SrcFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(100000, 150);
            this.MinimumSize = new System.Drawing.Size(363, 150);
            this.Name = "QuietFile";
            this.Text = "Get File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SrcFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DestDirectory;
        private System.Windows.Forms.TextBox txt_FileNameOverride;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuietFile;
        private System.Windows.Forms.CheckBox chk_CloseAfterSuccess;
        private System.Windows.Forms.Button btn_SelectSrcFilePath;
        private System.Windows.Forms.Button btn_SelectDestDir;
    }
}

