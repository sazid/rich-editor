namespace Rich_Editor
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reenterPasswordTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lastNameTb = new System.Windows.Forms.TextBox();
            this.dobPicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.userTypeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // usernameTb
            // 
            this.usernameTb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.usernameTb.Location = new System.Drawing.Point(12, 26);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(229, 20);
            this.usernameTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // passwordTb
            // 
            this.passwordTb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.passwordTb.Location = new System.Drawing.Point(12, 73);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.Size = new System.Drawing.Size(229, 20);
            this.passwordTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Re-enter password";
            // 
            // reenterPasswordTb
            // 
            this.reenterPasswordTb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.reenterPasswordTb.Location = new System.Drawing.Point(12, 120);
            this.reenterPasswordTb.Name = "reenterPasswordTb";
            this.reenterPasswordTb.Size = new System.Drawing.Size(229, 20);
            this.reenterPasswordTb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // firstNameTb
            // 
            this.firstNameTb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.firstNameTb.Location = new System.Drawing.Point(12, 172);
            this.firstNameTb.Name = "firstNameTb";
            this.firstNameTb.Size = new System.Drawing.Size(229, 20);
            this.firstNameTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Last Name";
            // 
            // lastNameTb
            // 
            this.lastNameTb.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lastNameTb.Location = new System.Drawing.Point(12, 220);
            this.lastNameTb.Name = "lastNameTb";
            this.lastNameTb.Size = new System.Drawing.Size(229, 20);
            this.lastNameTb.TabIndex = 11;
            // 
            // dobPicker
            // 
            this.dobPicker.Location = new System.Drawing.Point(12, 270);
            this.dobPicker.Name = "dobPicker";
            this.dobPicker.Size = new System.Drawing.Size(200, 20);
            this.dobPicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date of Birth";
            // 
            // userTypeCombo
            // 
            this.userTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userTypeCombo.FormattingEnabled = true;
            this.userTypeCombo.Items.AddRange(new object[] {
            "ReadOnly",
            "ReadWrite"});
            this.userTypeCombo.Location = new System.Drawing.Point(12, 323);
            this.userTypeCombo.Name = "userTypeCombo";
            this.userTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.userTypeCombo.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "User Type";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(12, 369);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(229, 23);
            this.submitBtn.TabIndex = 19;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(11, 398);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(229, 23);
            this.cancelBtn.TabIndex = 20;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 434);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userTypeCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dobPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reenterPasswordTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTb);
            this.Name = "NewUser";
            this.Text = "New User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reenterPasswordTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastNameTb;
        private System.Windows.Forms.DateTimePicker dobPicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox userTypeCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}