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
        public static string LOGIN_FILE = @"login.txt";

        private List<User> users;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Check if file exists, otherwise create one
            CheckFileExistance();
            users = CsvReader.ReadUsersFromCsv(LOGIN_FILE);
        }

        private void CheckFileExistance()
        {
            using (StreamWriter w = File.AppendText(LOGIN_FILE)) ;
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new NewUser().ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;

            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    new Editor().Show();
                    Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid credentials");
        }
    }
}
