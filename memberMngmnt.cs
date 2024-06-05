using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_borrowing
{
    public partial class memberMngmnt : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader, myReader1, myReader2;
        public memberMngmnt()
        {
            InitializeComponent();
        }
        private void memberMngmnt_Load(object sender, EventArgs e)
        {
            loadMembers();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Form1.instance.OpenChildForm(new home(), 210, 125);
        }
        #region CRUD
        private void addMember_Click(object sender, EventArgs e)
        {
            if (firstName.TextLength == 0 || lastName.TextLength == 0 || cnumber.TextLength == 0 || email.TextLength == 0 || gender.SelectedIndex == 0)
            {
                MessageBox.Show("Please Complete the Form", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE member_id = @mid", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@mid", memberId.Text);
                myReader = cmd.ExecuteReader();
                if(myReader.Read())
                {
                    MessageBox.Show("User Already Exist! Update record!", "Notice!");
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM members WHERE member_fname = @mfname AND member_lname = @mlname AND member_email = @memail AND member_number = @mcnum AND member_gender = @mgender", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@mfname", firstName.Text);
                    cmd1.Parameters.AddWithValue("@mlname", lastName.Text);
                    cmd1.Parameters.AddWithValue("@mcnum", cnumber.Text);
                    cmd1.Parameters.AddWithValue("@memail", email.Text);
                    cmd1.Parameters.AddWithValue("@mgender", gender.SelectedItem);
                    int exist = cmd1.ExecuteNonQuery();
                    if (exist > 0)
                    {
                        MessageBox.Show("Member Already Exist", "Notice!");
                    }
                    else
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO members VALUES('', @nfname, @nlname, @nemail, @ncnum, @ngender)", dbConnect.myconnect);
                        cmd2.Parameters.AddWithValue("@nfname", firstName.Text);
                        cmd2.Parameters.AddWithValue("@nlname", lastName.Text);
                        cmd2.Parameters.AddWithValue("@ncnum", cnumber.Text);
                        cmd2.Parameters.AddWithValue("@nemail", email.Text);
                        cmd2.Parameters.AddWithValue("@ngender", gender.SelectedItem);
                        int insert = cmd2.ExecuteNonQuery();
                        if(insert > 0)
                        {
                            MessageBox.Show("Member Added Successfully", "Success");
                            loadMembers();
                            clearForm();
                        }
                    }
                }
            }
        }
        private void updateMember_Click(object sender, EventArgs e)
        {
            if (firstName.TextLength == 0 || lastName.TextLength == 0 || email.TextLength == 0 || cnumber.TextLength == 0 || gender.SelectedIndex == 0)
            {
                MessageBox.Show("Please Complete the Form", "Notice!");
            }
            else if (memberId.TextLength == 0)
            {
                MessageBox.Show("Member Doesn't Exist in the System! Add a New One.", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE member_id != @eid AND member_fname = @efname AND member_lname = @elname AND member_email = @eemail AND member_number = @enumber AND member_gender = @egender", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@eid", memberId.Text);
                cmd.Parameters.AddWithValue("@efname", firstName.Text);
                cmd.Parameters.AddWithValue("@elname", lastName.Text);
                cmd.Parameters.AddWithValue("@enumber", cnumber.Text);
                cmd.Parameters.AddWithValue("@eemail", email.Text);
                cmd.Parameters.AddWithValue("@egender", gender.SelectedItem);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Member Details Already Exist in Different Member", "Notice!");
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE members SET member_fname = @ufname, member_lname = @ulname, member_email = @uemail, member_number = @unumber, member_gender = @ugender WHERE member_id = @uid", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@uid", memberId.Text);
                    cmd1.Parameters.AddWithValue("@ufname", firstName.Text);
                    cmd1.Parameters.AddWithValue("@ulname", lastName.Text);
                    cmd1.Parameters.AddWithValue("@uemail", email.Text);
                    cmd1.Parameters.AddWithValue("@unumber", cnumber.Text);
                    cmd1.Parameters.AddWithValue("@ugender", gender.SelectedItem);
                    int update = cmd1.ExecuteNonQuery();
                    if (update > 0)
                    {
                        MessageBox.Show("Member Details Updated Successfully", "Success!");
                        Form1.instance.manageMember_Click(null, null);
                    }
                }
            }
        }
        private void deleteMember_Click(object sender, EventArgs e)
        {
            if (memberId.TextLength == 0)
            {
                MessageBox.Show("Member Doesn't Exist in the System", "Notice!");
            }
            else if (MessageBox.Show("Are you sure you want to delete this member?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM book_transactions WHERE member_id = @tid", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@tid", memberId.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Cannot Delete member, still has a book borrowed.", "Notice!");
                    return;
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("DELETE FROM members WHERE member_id = @mid", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@mid", memberId.Text);
                    int delete = cmd1.ExecuteNonQuery();
                    if (delete > 0)
                    {
                        MessageBox.Show("Member Successfully Deleted!", "Notice!");
                        loadMembers();
                        clearForm();
                    }
                }
            }
        }
        #endregion

        private void readTransactions()
        {
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM book_transactions WHERE member_id = @tid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@tid", memberId.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                MessageBox.Show("Cannot Delete member, still has a book borrowed.", "Notice!");
                return;
            }
        }

        #region OTHERS
        private void memberId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void memberDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberId.Text = memberDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            firstName.Text = memberDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            lastName.Text = memberDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            email.Text = memberDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            cnumber.Text = memberDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            gender.SelectedItem = memberDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        #endregion

        #region METHODS
        private void loadMembers()
        {
            memberDgv.RowTemplate.Height = 30;
            memberDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM members", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            memberDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }
        private void clearForm()
        {
            memberId.Clear();
            firstName.Clear();
            lastName.Clear();
            email.Clear();
            cnumber.Clear();
            gender.SelectedIndex = 0;
        }
        #endregion
    }
}
