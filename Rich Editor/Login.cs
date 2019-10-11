using System;
using System.IO;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Check if file exists, otherwise create one
            CheckFileExistance();
        }

        private void CheckFileExistance()
        {
            using (StreamWriter w = File.AppendText("login.txt")) ;
        }
    }
}
