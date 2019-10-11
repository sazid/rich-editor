using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void NewFile() 
        {

        }

        private void OpenFile()
        {

        }

        private void SaveFile()
        {

        }

        private void SaveFileAs()
        {

        }

        private void Logout()
        {
            new Login().Show();
            Hide();
        }

        private void Cut()
        {

        }

        private void Copy()
        {

        }

        private void Paste()
        {

        }

        private void Bold()
        {

        }

        private void Italic()
        {

        }

        private void Underline()
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) => new AboutForm().Show();

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e) => Logout();
    }
}
