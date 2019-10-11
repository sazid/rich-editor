using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Rich_Editor
{
    public partial class Editor : Form
    {
        private string OPEN_FILE_PATH = null;
        private User user = null;

        public Editor(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Editor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool AllowEdit()
        {
            if (user.Type != UserType.ReadWrite)
            {
                MessageBox.Show("You're not allowed to edit.");
                return false;
            }
            return true;
        }

        private void NewFile() 
        {
            richEditor.Text = string.Empty;
            OPEN_FILE_PATH = null;
        }

        private void OpenFile()
        {
            string fileContent = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|Rich Text Format files (*.rtf)|*.rtf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    OPEN_FILE_PATH = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            richEditor.Text = fileContent;
        }

        private string ShowSaveFileDialog()
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.Title = "Save a Rich Text Document";
            saveFileDialog1.ShowDialog();

            return saveFileDialog1.FileName;
        }

        private void SaveFile()
        {
            if (!AllowEdit()) return;

            if (OPEN_FILE_PATH == null)
            {
                string tempPath = ShowSaveFileDialog();
                if (string.IsNullOrEmpty(tempPath)) return;

                OPEN_FILE_PATH = tempPath;
            }

            // Overwrite existing file
            string content = richEditor.Text;
            File.WriteAllText(OPEN_FILE_PATH, content);
        }

        private void SaveFileAs()
        {
            if (!AllowEdit()) return;

            string tempPath = ShowSaveFileDialog();
            if (string.IsNullOrEmpty(tempPath)) return;

            OPEN_FILE_PATH = tempPath;
            SaveFile();
        }

        private void Logout()
        {
            new Login().Show();
            Hide();
        }

        private void Cut()
        {
            if (!AllowEdit()) return;

        }

        private void Copy()
        {
            if (!AllowEdit()) return;

        }

        private void Paste()
        {
            if (!AllowEdit()) return;

        }

        private void Bold()
        {
            if (!AllowEdit()) return;

        }

        private void Italic()
        {
            if (!AllowEdit()) return;

        }

        private void Underline()
        {
            if (!AllowEdit()) return;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm().Show();

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) => Logout();

        private void Editor_Load(object sender, EventArgs e)
        {
            toolStripUsername.Text = user.Username;
            toolStripMode.Text = user.Type.ToString();
        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            if (!AllowEdit()) return;
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) => OpenFile();

        private void toolStripOpen_Click(object sender, EventArgs e) => OpenFile();

        private void toolStripSave_Click(object sender, EventArgs e) => SaveFile();

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) => SaveFile();

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) => SaveFileAs();

        private void toolStripSaveAs_Click(object sender, EventArgs e) => SaveFileAs();
    }
}
