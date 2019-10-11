using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt|Rich Text Format files (*.rtf)|*.rtf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    OPEN_FILE_PATH = openFileDialog.FileName;
                    richEditor.LoadFile(OPEN_FILE_PATH);
                }
            }
        }

        private string ShowSaveFileDialog()
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog1.Title = "Save a Rich Text Format Document";
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
            richEditor.SaveFile(OPEN_FILE_PATH);
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
            richEditor.Cut();
        }

        private void Copy()
        {
            if (!AllowEdit()) return;
            richEditor.Copy();
        }

        private void Paste()
        {
            if (!AllowEdit()) return;
            richEditor.Paste();
        }

        private void Bold()
        {
            if (!AllowEdit()) return;

            if (richEditor.SelectionFont != null)
            {
                Font currentFont = richEditor.SelectionFont;
                FontStyle newFontStyle;

                if (richEditor.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                }

                richEditor.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void Italic()
        {
            if (!AllowEdit()) return;

            if (richEditor.SelectionFont != null)
            {
                Font currentFont = richEditor.SelectionFont;
                FontStyle newFontStyle;

                if (richEditor.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                }

                richEditor.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void Underline()
        {
            if (!AllowEdit()) return;

            if (richEditor.SelectionFont != null)
            {
                Font currentFont = richEditor.SelectionFont;
                FontStyle newFontStyle;

                if (richEditor.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                }

                richEditor.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   newFontStyle
                );
            }
        }

        private void ChangeFontSize()
        {
            if (!AllowEdit()) return;

            if (richEditor.SelectionFont != null && toolStripFontSize.SelectedItem != null)
            {
                Font currentFont = richEditor.SelectionFont;

                float selectedFontSize;
                try
                {
                    selectedFontSize = float.Parse(toolStripFontSize.SelectedItem.ToString());
                }
                catch
                {
                    MessageBox.Show("Invalid font size");
                    return;
                }

                richEditor.SelectionFont = new Font(
                   currentFont.FontFamily,
                   selectedFontSize
                );
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm().Show();

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) => Logout();

        private void Editor_Load(object sender, EventArgs e)
        {
            toolStripUsername.Text = user.Username;
            toolStripMode.Text = user.Type.ToString();

            if (user.Type == UserType.ReadOnly) richEditor.ReadOnly = true;
            else richEditor.ReadOnly = false;
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

        private void toolStripBold_Click(object sender, EventArgs e) => Bold();

        private void toolStripItalic_Click(object sender, EventArgs e) => Italic();

        private void toolStripUnderline_Click(object sender, EventArgs e) => Underline();

        private void toolStripFontSize_SelectedIndexChanged(object sender, EventArgs e) => ChangeFontSize();

        private void toolStripCut_Click(object sender, EventArgs e) => Cut();

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) => Cut();

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) => Copy();

        private void toolStripCopy_Click(object sender, EventArgs e) => Copy();

        private void toolStripPaste_Click(object sender, EventArgs e) => Paste();

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) => Paste();

        private void toolStripHelp_Click(object sender, EventArgs e) => new AboutForm().Show();

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) => richEditor.Undo();

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) => richEditor.Redo();

        private void boldToolStripMenuItem_Click(object sender, EventArgs e) => Bold();

        private void italicToolStripMenuItem_Click(object sender, EventArgs e) => Italic();

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e) => Underline();

        private void toolStripUndo_Click(object sender, EventArgs e) => richEditor.Undo();

        private void toolStripRedo_Click(object sender, EventArgs e) => richEditor.Redo();
    }
}
