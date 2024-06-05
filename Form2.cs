using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_borrowing
{
    public partial class Form2 : Form
    {
        string user = "admin";
        string pass = "password";
        public Form2()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if(username.TextLength == 0 || password.TextLength == 0)
            {
                MessageBox.Show("Please Fill Up the Form", "Notice!");
            }
            else
            {
                if (username.Text == user)
                {
                    if (password.Text == pass)
                    {
                        Form1 frm1 = new Form1();
                        frm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Password is incorrect", "Notice!");
                    }
                }
                else
                {
                    MessageBox.Show("Username is incorrect", "Notice!");
                }
            }
        }

    }
}
