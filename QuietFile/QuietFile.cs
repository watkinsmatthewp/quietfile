using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuietFile
{
    public partial class QuietFile : Form
    {
        // private variables
        private FileGetter _fileGetter;
        
        // Ctor
        public QuietFile(string[] args)
        {
            InitializeComponent();
            ProcessArgs(args);
            UpdateButtonStatus();
        }

        #region UI Event handlers

        private void txt_SrcFilePath_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }
        private void txt_DestDirectory_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void txt_FileNameOverride_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonStatus();
        }

        private void btnQuietFile_Click(object sender, EventArgs e)
        {
            string destinationFilePath = GetDestinationFilePath();
            _fileGetter = new FileGetter(txt_SrcFilePath.Text, destinationFilePath)
            {
                AllowOverwrite = true
            };
            _fileGetter.ProcessFinished += OnProcessFinished;
            _fileGetter.Start();
        }

        private void btn_SelectSrcFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Multiselect = false,
                ShowHelp = true
            };
            DialogResult result = openFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txt_SrcFilePath.Text = openFileDialog.FileName;
            }
        }

        private void btn_SelectDestDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog()
            {
                Description = "Select the destination directory",
                ShowNewFolderButton = true,
                RootFolder = Environment.SpecialFolder.DesktopDirectory
            };
            DialogResult result = folderBrowser.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txt_DestDirectory.Text = folderBrowser.SelectedPath;
            }
        }

        #endregion

        #region Process Event handlers

        private void OnProcessFinished(FileCopyResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(delegate()
                {
                    // re-call this method on the correct thread
                    OnProcessFinished(result);
                }));
            }
            else
            {
                switch (result.Status)
                {
                    case FileCopyResultStatus.Success:
                        if (chk_CloseAfterSuccess.Checked)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            MessageBox.Show("The file was successfully copied", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    case FileCopyResultStatus.Error:
                        MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        throw new Exception("Unrecognized or none enum value: " + result.Status.ToString());
                }
            }
        }

        #endregion

        #region Helpers

        private void ProcessArgs(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Dictionary<string, string> parsedArgs = GetParsedArgs(args);
                if (parsedArgs.Count > 0)
                {
                    if (parsedArgs.ContainsKey("destinationFolder"))
                    {
                        txt_DestDirectory.Text = parsedArgs["destinationFolder"];
                    }
                    if (parsedArgs.ContainsKey("sourceFile"))
                    {
                        txt_SrcFilePath.Text = parsedArgs["sourceFile"];
                    }
                    if (parsedArgs.ContainsKey("closeAfterSuccessfulCopy"))
                    {
                        bool closeAfterSuccessfulCopy = false;
                        bool.TryParse(parsedArgs["closeAfterSuccessfulCopy"], out closeAfterSuccessfulCopy);
                        chk_CloseAfterSuccess.Checked = closeAfterSuccessfulCopy;
                    }
                }
            }
        }

        private Dictionary<string, string> GetParsedArgs(string[] args)
        {
            Dictionary<string, string> parsedArgs = new Dictionary<string, string>();
            if (args != null && args.Length > 0)
            {
                foreach (string arg in args)
                {
                    string argCopy = arg;
                    if (argCopy.StartsWith("-") || argCopy.StartsWith("/"))
                    {
                        argCopy = argCopy.Substring(1);
                    }

                    int delimeterIndex = argCopy.IndexOf('=');
                    if (delimeterIndex > -1)
                    {
                        string key = argCopy.Substring(0, delimeterIndex);
                        string value = argCopy.Substring(delimeterIndex + 1, argCopy.Length - (key.Length + 1));
                        if (value.StartsWith("\"") && value.EndsWith("\""))
                        {
                            if (value.Length > 2)
                            {
                                value = value.Substring(1, value.Length - 2);
                            }
                            else
                            {
                                value = String.Empty;
                            }
                        }

                        if (!parsedArgs.ContainsKey(key))
                        {
                            parsedArgs.Add(key, String.Empty);
                        }
                        parsedArgs[key] = value;
                    }
                }
            }
            return parsedArgs;
        }

        private void UpdateButtonStatus()
        {
            btnQuietFile.Enabled = !String.IsNullOrWhiteSpace(txt_DestDirectory.Text) && !String.IsNullOrWhiteSpace(txt_SrcFilePath.Text);
        }

        private string GetDestinationFilePath()
        {
            string fileName;
            if (String.IsNullOrWhiteSpace(txt_FileNameOverride.Text))
            {
                fileName = Path.GetFileName(txt_SrcFilePath.Text);
            }
            else
            {
                fileName = txt_FileNameOverride.Text;
            }

            return Path.Combine(txt_DestDirectory.Text, fileName);
        }

        #endregion
    }
}
