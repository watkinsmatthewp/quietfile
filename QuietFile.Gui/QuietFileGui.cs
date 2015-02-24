using QuietFile.Backend;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace QuietFile.Gui
{
    public partial class QuietFileGui : Form
    {
        public QuietFileGui(string[] args)
        {
            InitializeComponent();
            ProcessArgs(args);

            // Update the button status whenever one of the required fields changes
            txt_DestinationDirectory.TextChanged += UpdateStartButtonEnabledStatus;
            txt_SourcePath.TextChanged += UpdateStartButtonEnabledStatus;

            // update button status (in case args were pased in that make it valid now)
            UpdateStartButtonEnabledStatus();
        }

        #region UI Listeners

        private void UpdateStartButtonEnabledStatus(object sender, EventArgs e)
        {
            UpdateStartButtonEnabledStatus();
        }

        private void btn_ChooseLocalSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
                Multiselect = true
            };
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_SourcePath.Text = fileDialog.FileName;
            }
        }

        private void btn_SelectDestinationDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                Description = "Select a folder to receive the file",
                RootFolder = Environment.SpecialFolder.DesktopDirectory,
                ShowNewFolderButton = true
            };
            if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_DestinationDirectory.Text = folderDialog.SelectedPath;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string destinationFilePath = GetDestinationFilePath();
            FileGetter getter = FileGetter.Create(txt_SourcePath.Text, destinationFilePath);
            getter.OverwiteDestinationPath = chk_OverwriteDestinationFile.Checked;
            getter.ProcessFinished += OnProcessFinished;

            // Run the get
            getter.StartAsync();
        }

        private void OnProcessFinished(FileCopyResult result)
        {
            switch (result.Status)
            {
                case FileCopyResultStatus.Error:
                    ShowError("Error", result.ErrorMessage);
                    break;
                case FileCopyResultStatus.Success:
                    if (chk_CloseAfterSuccess.Checked)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        MessageBox.Show("Success");
                    }
                    break;
                default:
                    throw new Exception("Status: " + result.Status.ToString());
            }
        }

        #endregion

        #region Private helpers

        private void ProcessArgs(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Dictionary<string, string> parsedArgs = GetParsedArgs(args);
                if (parsedArgs.Count > 0)
                {
                    if (parsedArgs.ContainsKey("destinationFolder"))
                    {
                        txt_DestinationDirectory.Text = parsedArgs["destinationFolder"];
                    }
                    if (parsedArgs.ContainsKey("sourceFile"))
                    {
                        txt_SourcePath.Text = parsedArgs["sourceFile"];
                    }
                    if (parsedArgs.ContainsKey("closeAfterSuccessfulCopy"))
                    {
                        chk_CloseAfterSuccess.Checked = true;
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

        private void UpdateStartButtonEnabledStatus()
        {
            btn_Start.Enabled = !String.IsNullOrWhiteSpace(txt_DestinationDirectory.Text) && !String.IsNullOrWhiteSpace(txt_SourcePath.Text);
        }

        private void ShowError(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string GetDestinationFilePath()
        {
            string fileName = String.IsNullOrWhiteSpace(txt_FileNameOverride.Text) ? Path.GetFileName(txt_SourcePath.Text) : txt_FileNameOverride.Text;
            return Path.Combine(txt_DestinationDirectory.Text, fileName);
        }

        #endregion
    }
}
