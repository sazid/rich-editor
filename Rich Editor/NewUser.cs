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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            new Login().Show();
            Hide();
        }
    }
}
