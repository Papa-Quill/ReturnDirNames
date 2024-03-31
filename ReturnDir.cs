using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ReturnDirNames
{
    public partial class ReturnDir : Form
    {
        public ReturnDir()
        {
            InitializeComponent();
            KeyDown += ReturnDir_KeyDown;
            KeyUp += ReturnDir_KeyUp;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.W))
            {
                Close();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private string selectedFolder;
        private string[] filesAndFolders;

        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Folder";
                    openFileDialog.CheckFileExists = false;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.FileName = "Select Folder";
                    openFileDialog.Filter = "Folders|\n";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        selectedFolder = Path.GetDirectoryName(openFileDialog.FileName);
                        filesAndFolders = Directory.GetFileSystemEntries(selectedFolder);

                        // Display the names of files and folders in ListBoxFiles
                        ListBoxFiles.Items.Clear();
                        ListBoxFiles.Items.AddRange(filesAndFolders);
                    }
                }
            }
            else
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Folder Truncated"; // Set the title to "Select Folder"
                    openFileDialog.CheckFileExists = false;
                    openFileDialog.CheckPathExists = true;
                    openFileDialog.FileName = "Select Folder";
                    openFileDialog.Filter = "Folders|\n";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFolder = Path.GetDirectoryName(openFileDialog.FileName);

                        string[] filesAndFolders = Directory.GetFileSystemEntries(selectedFolder);

                        // Display the names of files and folders in ListBoxFiles
                        ListBoxFiles.Items.Clear();
                        foreach (string fileOrFolder in filesAndFolders)
                        {
                            ListBoxFiles.Items.Add(Path.GetFileName(fileOrFolder)); // Add only file/folder name without path
                        }
                    }
                }
            }
        }

        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            if (ListBoxFiles.Items.Count == 0)
            {
                MessageBox.Show("No files or folders selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine if any items are selected in the ListBoxFiles
            bool anySelected = ListBoxFiles.SelectedItems.Count > 0;
            if (Control.ModifierKeys == Keys.Control)
            {
                if (anySelected)
                {
                    // Save only selected items
                    foreach (var selectedItem in ListBoxFiles.SelectedItems)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var item in ListBoxFiles.SelectedItems)
                        {
                            sb.AppendLine(item.ToString());
                        }
                        string fileNames = sb.ToString().TrimEnd(); // Remove the trailing newline
                        Clipboard.SetText(fileNames);
                    }
                    MessageBox.Show("File names copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Save all items
                    foreach (var item in ListBoxFiles.Items)
                    {
                        StringBuilder sb = new StringBuilder();
                        foreach (var items in ListBoxFiles.Items)
                        {
                            sb.AppendLine(items.ToString());
                        }
                        string fileNames = sb.ToString().TrimEnd(); // Remove the trailing newline
                        Clipboard.SetText(fileNames);
                    }
                    MessageBox.Show("File names copied to clipboard.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Title = "Save File Names";
                    saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
                    saveFileDialog.DefaultExt = "txt";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                            {
                                if (anySelected)
                                {
                                    // Save only selected items
                                    foreach (var selectedItem in ListBoxFiles.SelectedItems)
                                    {
                                        writer.WriteLine(selectedItem.ToString());
                                    }
                                }
                                else
                                {
                                    // Save all items
                                    foreach (var item in ListBoxFiles.Items)
                                    {
                                        writer.WriteLine(item.ToString());
                                    }
                                }
                            }
                            MessageBox.Show("File names saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error saving file names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ReturnDir_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Control)
            {
                BtnSelectFolder.Text = "Select Folder (Full Dir)";
                BtnSaveFile.Text = "Copy to Clipboard";
            }
        }

        private void ReturnDir_KeyUp(object sender, KeyEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Control)
            {
                BtnSelectFolder.Text = "Select Folder";
                BtnSaveFile.Text = "Save to File";
            }
        }

        private void ReturnDir_Enter(object sender, EventArgs e)
        {
            if (Control.ModifierKeys != Keys.Control)
            {
                BtnSelectFolder.Text = "Select Folder";
                BtnSaveFile.Text = "Save to File";
            }
        }
    }
}
