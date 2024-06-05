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
    public partial class Form1 : Form
    {
        public static Form1 instance;
        private Form currentchildForm;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            timer1.Start();
        }
        #region Upperbuttons
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new home(), 210, 125);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            currentTime.Text = time.ToString("MMM dd, yyyy hh:mm:ss tt dddd");
        }
        public void OpenChildForm(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Hide();
            }
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.None;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            childForm.Size = new Size(1321, 735);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Anchor = AnchorStyles.Bottom;
            childForm.Anchor = AnchorStyles.Top;
            childForm.Anchor = AnchorStyles.Right;
            childForm.Anchor = AnchorStyles.Left;
            childForm.Location = new Point(xpos, ypos);
        }

        private void home_Click(object sender, EventArgs e)
        {
            OpenChildForm(new home(), 210, 125);
        }

        public void manageBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new bookMngmnt(), 210, 125);
        }

        public void manageMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new memberMngmnt(), 210, 125);
        }

        private void borrowBook_Click(object sender, EventArgs e)
        {
            OpenChildForm(new borrowBook(), 210, 125);
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Log-Out?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.WindowState = FormWindowState.Minimized;
                Form2 f2 = new Form2();
                f2.Show();
            }
        }
    }
}
