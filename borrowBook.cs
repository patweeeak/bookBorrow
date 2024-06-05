using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_borrowing
{
    public partial class borrowBook : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader, myReader1, myReader2;
        DateTime dates = DateTime.Now.Date;
        DataTable bdt = new DataTable();
        DataTable rdt = new DataTable();
        public borrowBook()
        {
            InitializeComponent();
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Form1.instance.OpenChildForm(new home(), 210, 125);
        }
        private void borrowBook_Load(object sender, EventArgs e)
        {
            loadBook();
            loadBorrowedbook();
            borrowPanel.Visible = false;
            returnPanel.Visible = false;
        }
        #region SEARCH
        private void borrowSearchBox_TextChanged(object sender, EventArgs e)
        {
            borrowSearch();
        }
        private void returnSearchBox_TextChanged(object sender, EventArgs e)
        {
            returnSearch();
        }
        #endregion

        #region METHODS
        private void loadBook()
        {
            borrowDgv.RowTemplate.Height = 30;
            //borrowDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT books.book_id, books.book_title, publishers.publisher_name, categories.category_name FROM books RIGHT JOIN publishers ON books.publisher_id = publishers.publisher_id RIGHT JOIN categories ON books.category_id = categories.category_id WHERE books.booktype_id = '2' GROUP BY books.book_id ASC", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(bdt);
            borrowDgv.DataSource = bdt;
            dbConnect.CloseConnection();
        }
        private void loadBorrowedbook()
        {
            rdt.Clear();
            returnDgv.RowTemplate.Height = 30;
            returnDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT book_transactions.transaction_id, book_transactions.transaction_status, books.book_id, books.book_title, members.member_id, members.member_fname, members.member_lname FROM book_transactions RIGHT JOIN books ON book_transactions.book_id = books.book_id RIGHT JOIN members ON book_transactions.member_id = members.member_id WHERE book_transactions.transaction_status = 'Borrowed'", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(rdt);
            returnDgv.DataSource = rdt;
            dbConnect.CloseConnection();
        }
        private void retrieveDate()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT borrowed_date FROM book_transactions WHERE transaction_id = @tid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@tid", transactionID.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                dateBorrowed.Text = myReader.GetString("borrowed_date");
            }
        }
        private void borrowSearch()
        {
            bdt.Clear();
            borrowDgv.RowTemplate.Height = 30;
            borrowDgv.ReadOnly = true;
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT books.book_id, books.book_title, publishers.publisher_name, categories.category_name FROM books RIGHT JOIN publishers ON books.publisher_id = publishers.publisher_id RIGHT JOIN categories ON books.category_id = categories.category_id WHERE CONCAT (books.book_title, publishers.publisher_name) LIKE @item AND books.booktype_id = '2' GROUP BY books.book_id ASC", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + borrowSearchBox.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(bdt);
            borrowDgv.DataSource = bdt;
            dbConnect.CloseConnection();
            if(borrowDgv.Rows.Count > 0)
            {
                borrowPanel.Visible = false;
            }
            else
            {
                borrowPanel.Visible = true;
            }
        }
        private void returnSearch()
        {
            rdt.Clear();
            returnDgv.RowTemplate.Height = 30;
            returnDgv.ReadOnly = true;
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT book_transactions.transaction_id, book_transactions.transaction_status, books.book_id, books.book_title, members.member_id, members.member_fname, members.member_lname FROM book_transactions RIGHT JOIN books ON book_transactions.book_id = books.book_id RIGHT JOIN members ON book_transactions.member_id = members.member_id WHERE CONCAT (books.book_title, members.member_fname, members.member_lname) LIKE @item AND book_transactions.transaction_status = 'Borrowed'", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@item", "%" + returnSearchBox.Text + "%");
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(rdt);
            returnDgv.DataSource = rdt;
            dbConnect.CloseConnection();
            if (returnDgv.Rows.Count > 0)
            {
                returnPanel.Visible = false;
            }
            else
            {
                returnPanel.Visible = true;
            }
        }
        #endregion

        #region CLICKS
        private void returnDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionID.Text = returnDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            retrieveDate();
            returnerId.Text = returnDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            rBookid.Text = returnDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void borrowDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bBookid.Text = borrowDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void borrow_Click(object sender, EventArgs e)
        {
            string borrowerID = "", bookID = "";
            if (borrowerId.TextLength == 0 || bBookid.TextLength == 0)
            {
                MessageBox.Show("Please Complete the Form", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE member_id = @checkid", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@checkid", borrowerId.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    borrowerID = myReader["member_id"].ToString();
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM books WHERE book_id = @checkbook AND booktype_id = '2'", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@checkbook", bBookid.Text);
                    myReader1 = cmd1.ExecuteReader();
                    if (myReader1.Read())
                    {
                        bookID = myReader1["book_id"].ToString();
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd2 = new MySqlCommand("INSERT INTO book_transactions VALUES('', @transacDate, '', @bookid, @memberid, 'Borrowed')", dbConnect.myconnect);
                        cmd2.Parameters.AddWithValue("@transacDate", dates.ToString("MM-dd-yyyy"));
                        cmd2.Parameters.AddWithValue("@bookid", bookID);
                        cmd2.Parameters.AddWithValue("@memberid", borrowerID);
                        int transaction = cmd2.ExecuteNonQuery();
                        if (transaction > 0)
                        {
                            MessageBox.Show("Book Borrowed Successfully!", "Success!");
                            bBookid.Clear();
                            borrowerId.Clear();
                            loadBorrowedbook();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book Doesn't Exist in the System or Cannot be borrowed", "Notice!");
                    }
                }
                else
                {
                    MessageBox.Show("No Member Found with the Inputted ID");
                }
            }
        }
        private void returnBook_Click(object sender, EventArgs e)
        {
            if (returnerId.TextLength == 0 || rBookid.TextLength == 0 || dateBorrowed.TextLength == 0)
            {
                MessageBox.Show("Please Complete the Form!", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM members WHERE member_id = @checkid", dbConnect.myconnect);
                cmd.Parameters.AddWithValue("@checkid", returnerId.Text);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM books WHERE book_id = @checkbook AND booktype_id = '2'", dbConnect.myconnect);
                    cmd1.Parameters.AddWithValue("@checkbook", rBookid.Text);
                    myReader1 = cmd1.ExecuteReader();
                    if (myReader1.Read())
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd2 = new MySqlCommand("UPDATE book_transactions SET return_date = @transacDate, transaction_status = 'Returned' WHERE borrowed_date = @borrowedDate AND book_id = @bookid AND member_id = @memberid", dbConnect.myconnect);
                        cmd2.Parameters.AddWithValue("@transacDate", dates.ToString("MM-dd-yyyy"));
                        cmd2.Parameters.AddWithValue("@bookid", rBookid.Text);
                        cmd2.Parameters.AddWithValue("@memberid", returnerId.Text);
                        cmd2.Parameters.AddWithValue("@borrowedDate", dateBorrowed.Text);
                        int transaction = cmd2.ExecuteNonQuery();
                        if (transaction > 0)
                        {
                            deleteTransaction();
                            MessageBox.Show("Book Returned Successfully!", "Success!");
                            rBookid.Clear();
                            returnerId.Clear();
                            dateBorrowed.Clear();
                            loadBorrowedbook();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Book Doesn't Exist in the System or Cannot be borrowed", "Notice!");
                    }
                }
                else
                {
                    MessageBox.Show("No Member Found with the Inputted ID");
                }
            }
        }

        #endregion
        private void deleteTransaction()
        {
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM book_transactions WHERE return_date = @transacDate AND transaction_status = 'Returned' AND borrowed_date = @borrowedDate AND book_id = @bookid AND member_id = @memberid", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@transacDate", dates.ToString("MM-dd-yyyy"));
            cmd.Parameters.AddWithValue("@bookid", rBookid.Text);
            cmd.Parameters.AddWithValue("@memberid", returnerId.Text);
            cmd.Parameters.AddWithValue("@borrowedDate", dateBorrowed.Text);
            cmd.ExecuteNonQuery();
        }
    }
}
