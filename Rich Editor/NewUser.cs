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

        private void Msg(string msg)
        {
            MessageBox.Show(msg);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTb.Text;
            string password = passwordTb.Text;
            string firstName = firstNameTb.Text;
            string lastName = lastNameTb.Text;
            string rePassword = reenterPasswordTb.Text;
            string dob = $"{dobPicker.Value.Day}/{dobPicker.Value.Month}/{dobPicker.Value.Year}";
            string userType = null;

            if (userTypeCombo.SelectedItem != null) userType = userTypeCombo.SelectedItem.ToString();

            if (string.IsNullOrEmpty(username)) { Msg("Username cannot be empty"); return; }
            if (string.IsNullOrEmpty(password)) { Msg("Password cannot be empty"); return; }
            if (password != rePassword) { Msg("Passwords do not match"); return; }
            if (string.IsNullOrEmpty(password)) { Msg("Password cannot be empty"); return; }
            if (string.IsNullOrEmpty(firstName)) { Msg("First name cannot be empty"); return; }
            if (string.IsNullOrEmpty(lastName)) { Msg("Last name cannot be empty"); return; }
            if (string.IsNullOrEmpty(dob)) { Msg("Date of Birth must be selected"); return; }
            if (string.IsNullOrEmpty(userType)) { Msg("User type must be selected"); return; }

            User user = new User()
            {
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                DOB = dob
            };

            if (userType == UserType.ReadOnly.ToString()) user.Type = UserType.ReadOnly;
            else user.Type = UserType.ReadWrite;

            List<User> users = CsvReader.ReadUsersFromCsv(Login.LOGIN_FILE);
            users.Add(user);

            CsvReader.WriteUsersIntoCsv(Login.LOGIN_FILE, users);

            MessageBox.Show("Successfully added a new user!");
            
            Hide();
            new Login().Show();
        }
    }
}
