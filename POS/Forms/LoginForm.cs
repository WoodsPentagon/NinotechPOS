﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POS.Misc;
namespace POS.Forms
{
    public partial class LoginForm : Form
    {
        //UserManager u;
        public bool LoginSuccessful
        {
            get; private set;
        }
        public LoginForm()
        {
            InitializeComponent();
            //u = manager;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginSuccessful = UserManager.instance.Login(username.Text, password.Text);
            if (LoginSuccessful)
            {
                this.Close();
                return;
            }
            MessageBox.Show("User not found.");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tryConnect();
        }

        void tryConnect()
        {
            try
            {
                using (var p = new POSEntities())
                {
                    username.AutoCompleteCustomSource.AddRange(p.Logins.Select(x => x.Username).ToArray());
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message + "\n\nMake sure the server is on and is connected before clicking retry.", "Connection Failed!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    tryConnect();
                }
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {

        }

        private void hide_MouseDown(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\0';
        }

        private void hide_MouseUp(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '*';
        }
    }
}
