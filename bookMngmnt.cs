using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_borrowing
{
    public partial class bookMngmnt : Form
    {
        private Conclass dbConnect;
        private MySqlCommand cmd;
        private MySqlDataReader myReader;
        string publisherID = "";
        string categoryID = ""; 
        string booktypeID= "";
        DateTime dates = DateTime.Now.Date;
        public bookMngmnt()
        {
            InitializeComponent();
        }
        private void bookMngmnt_Load(object sender, EventArgs e)
        {
            bookPublisher.Visible = false;
            bookCategory.Visible = false;
            bookDate.Text = dates.ToString("MM-dd-yyyy");
            bookCategories();
            bookPublishers();
            loadBooks();
            updatingTitle.Visible = false;
            label9.Visible = false;
            newBook.Visible = false;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Form1.instance.OpenChildForm(new home(), 210, 125);
        }

        #region linkClick
        private void publisherLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (publisherCb.Visible == true)
            {
                bookPublisher.Visible = true;
                publisherCb.SelectedIndex = 0;
                publisherCb.Visible = false;
                publisherTxt.Text = "Existing Publisher?";
                publisherTxt.Location = new System.Drawing.Point(publisherTxt.Location.X - 22, publisherTxt.Location.Y);
            }
            else
            {
                bookPublisher.Visible = false;
                publisherCb.Visible = true;
                publisherTxt.Text = "New Publisher?";
                publisherTxt.Location = new System.Drawing.Point(publisherTxt.Location.X + 22, publisherTxt.Location.Y);
            }
        }
        private void categoryLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (categoryCb.Visible == true)
            {
                bookCategory.Visible = true;
                categoryCb.Visible = false;
                categoryCb.SelectedIndex = 0;
                categoryTxt.Text = "Existing Category?";
                categoryTxt.Location = new System.Drawing.Point(categoryTxt.Location.X - 22, categoryTxt.Location.Y);
            }
            else
            {
                bookCategory.Visible = false;
                categoryCb.Visible = true;
                categoryTxt.Text = "New Category?";
                categoryTxt.Location = new System.Drawing.Point(categoryTxt.Location.X + 22, categoryTxt.Location.Y);
            }
        }
        private void newBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.instance.manageBook_Click(null, null);
/*            publisherCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;
            bookTypeCb.SelectedIndex = 0;
            bookId.Clear();
            bookTitle.Visible = true;
            updatingTitle.Visible = false;
            label9.Visible = false;
            newBook.Visible = false;*/
        }
        #endregion

        #region CRUD
        private void addBook_Click(object sender, EventArgs e)
        {
            if (bookTitle.TextLength == 0 || bookPublisher.TextLength == 0 && publisherCb.SelectedIndex == 0 || bookCategory.TextLength == 0 && categoryCb.SelectedIndex == 0 || bookTypeCb.SelectedIndex == 0)
            {
                MessageBox.Show("Please Complete the Form", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM books WHERE book_id = @upid", dbConnect.myconnect);
                cmd4.Parameters.AddWithValue("@upid", bookId.Text);
                int no = cmd4.ExecuteNonQuery();
                if (no > 0)
                {
                    MessageBox.Show("Book is already in the system. Update It", "Notice!");
                }
                else
                {
                    if (publisherTxt.Text == "Existing Publisher?") // Creating new Publisher
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM publishers WHERE publisher_name = @pubName", dbConnect.myconnect);
                        cmd2.Parameters.AddWithValue("@pubName", bookPublisher.Text);
                        myReader = cmd2.ExecuteReader();
                        if (myReader.Read())
                        {
                            MessageBox.Show("Publisher Already Exist!", "Notice!");
                            dbConnect.CloseConnection();
                        }
                        else
                        {
                            newPublisher();
                            if (categoryTxt.Text == "Existing Category?") // Creating New Category
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM categories WHERE category_name = @categName", dbConnect.myconnect);
                                cmd3.Parameters.AddWithValue("@categName", bookCategory.Text);
                                myReader = cmd3.ExecuteReader();
                                if (myReader.Read())
                                {
                                    MessageBox.Show("Category Already Exist!", "Notice!");
                                    dbConnect.CloseConnection();
                                }
                                else
                                {
                                    newCategory();
                                    dbConnect.CloseConnection();
                                    dbConnect = new Conclass();
                                    dbConnect.OpenConnection();
                                    MySqlCommand cmd = new MySqlCommand("INSERT INTO books VALUES('', @btitle, @bpublisher, @date, @bcateg, @btype)", dbConnect.myconnect);
                                    cmd.Parameters.AddWithValue("@btitle", bookTitle.Text);
                                    cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                    cmd.Parameters.AddWithValue("@date", dates.ToString("MM-dd-yyyy"));
                                    cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                    cmd.Parameters.AddWithValue("@btype", booktypeID);
                                    int num1 = cmd.ExecuteNonQuery();
                                    if (num1 > 0)
                                    {
                                        MessageBox.Show("Book Added Successfully", "Success");
                                        bookTitle.Clear();
                                        bookCategory.Clear();
                                        bookPublisher.Clear();
                                        publisherCb.SelectedIndex = 0;
                                        categoryCb.SelectedIndex = 0;
                                        bookTypeCb.SelectedIndex = 0;
                                        timer1.Start();
                                        int pub = publisherCb.Items.Count;
                                        int categ = categoryCb.Items.Count;
                                        for (int i = pub - 1; i > 0; i--)
                                        {
                                            publisherCb.Items.RemoveAt(i);
                                        }
                                        for (int i = categ - 1; i > 0; i--)
                                        {
                                            categoryCb.Items.RemoveAt(i);
                                        }
                                        bookPublishers();
                                        bookCategories();
                                        loadBooks();
                                    }
                                }
                            }
                            else // Selecting Category from CB
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO books VALUES('', @btitle, @bpublisher, @date, @bcateg, @btype)", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@btitle", bookTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@date", dates.ToString("MM-dd-yyyy"));
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Added Successfully", "Success");
                                    bookTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                    }
                    else // Chosen Publisher from CB
                    {
                        if (categoryTxt.Text == "Existing Category?") // Creating new Category
                        {
                            dbConnect.CloseConnection();
                            dbConnect = new Conclass();
                            dbConnect.OpenConnection();
                            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM categories WHERE category_name = @categName", dbConnect.myconnect);
                            cmd3.Parameters.AddWithValue("@categName", bookCategory.Text);
                            myReader = cmd3.ExecuteReader();
                            if (myReader.Read())
                            {
                                MessageBox.Show("Category Already Exist!", "Notice!");
                                dbConnect.CloseConnection();
                            }
                            else
                            {
                                newCategory();
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO books VALUES('', @btitle, @bpublisher, @date, @bcateg, @btype)", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@btitle", bookTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@date", dates.ToString("MM-dd-yyyy"));
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Added Successfully", "Success");
                                    bookTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                        else // Chosen Category from CB
                        {
                            dbConnect = new Conclass();
                            dbConnect.OpenConnection();
                            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM books WHERE book_id = @bid AND book_title = @btitle AND publisher_id = @bpublisher AND category_id = @bcateg AND booktype_id = @btype", dbConnect.myconnect);
                            cmd1.Parameters.AddWithValue("@bid", bookId.Text);
                            cmd1.Parameters.AddWithValue("@btitle", bookTitle.Text);
                            cmd1.Parameters.AddWithValue("@bpublisher", publisherID);
                            cmd1.Parameters.AddWithValue("@bcateg", categoryID);
                            cmd1.Parameters.AddWithValue("@btype", booktypeID);
                            myReader = cmd1.ExecuteReader();
                            if (myReader.Read())
                            {
                                MessageBox.Show("Book Already Exist!", "Notice!");
                                dbConnect.CloseConnection();
                            }
                            else
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("INSERT INTO books VALUES('', @btitle, @bpublisher, @date, @bcateg, @btype)", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@btitle", bookTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@date", dates.ToString("MM-dd-yyyy"));
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Added Successfully", "Success");
                                    bookTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                    }
                }
            }
        }
        private void updateBook_Click(object sender, EventArgs e)
        {
            if (updatingTitle.TextLength == 0 || bookPublisher.TextLength == 0 && publisherCb.SelectedIndex == 0 || bookCategory.TextLength == 0 && categoryCb.SelectedIndex == 0 || bookTypeCb.SelectedIndex == 0)
            {
                MessageBox.Show("Please Complete the Form", "Notice!");
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd4 = new MySqlCommand("SELECT * FROM books WHERE book_id = @upid", dbConnect.myconnect);
                cmd4.Parameters.AddWithValue("@upid", bookId.Text);
                myReader = cmd4.ExecuteReader();
                if (myReader.Read())
                {
                    if (publisherTxt.Text == "Existing Publisher?") // Creating new Publisher
                    {
                        dbConnect.CloseConnection();
                        dbConnect = new Conclass();
                        dbConnect.OpenConnection();
                        MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM publishers WHERE publisher_name = @pubName", dbConnect.myconnect);
                        cmd2.Parameters.AddWithValue("@pubName", bookPublisher.Text);
                        myReader = cmd2.ExecuteReader();
                        if (myReader.Read())
                        {
                            MessageBox.Show("Publisher Already Exist!", "Notice!");
                            dbConnect.CloseConnection();
                        }
                        else
                        {
                            newPublisher();
                            if (categoryTxt.Text == "Existing Category?") // Creating new Category
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM categories WHERE category_name = @categName", dbConnect.myconnect);
                                cmd3.Parameters.AddWithValue("@categName", bookCategory.Text);
                                myReader = cmd3.ExecuteReader();
                                if (myReader.Read())
                                {
                                    MessageBox.Show("Category Already Exist!", "Notice!");
                                    dbConnect.CloseConnection();
                                }
                                else
                                {
                                    newCategory();
                                    dbConnect.CloseConnection();
                                    dbConnect = new Conclass();
                                    dbConnect.OpenConnection();
                                    MySqlCommand cmd = new MySqlCommand("UPDATE books SET book_title = @btitle, publisher_id = @bpublisher, category_id = @bcateg, booktype_id = @btype WHERE book_id = @bid", dbConnect.myconnect);
                                    cmd.Parameters.AddWithValue("@bid", bookId.Text);
                                    cmd.Parameters.AddWithValue("@btitle", updatingTitle.Text);
                                    cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                    cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                    cmd.Parameters.AddWithValue("@btype", booktypeID);
                                    int num1 = cmd.ExecuteNonQuery();
                                    if (num1 > 0)
                                    {
                                        MessageBox.Show("Book Updated Successfully", "Success");
                                        updatingTitle.Clear();
                                        bookCategory.Clear();
                                        bookPublisher.Clear();
                                        publisherCb.SelectedIndex = 0;
                                        categoryCb.SelectedIndex = 0;
                                        bookTypeCb.SelectedIndex = 0;
                                        timer1.Start();
                                        int pub = publisherCb.Items.Count;
                                        int categ = categoryCb.Items.Count;
                                        for (int i = pub - 1; i > 0; i--)
                                        {
                                            publisherCb.Items.RemoveAt(i);
                                        }
                                        for (int i = categ - 1; i > 0; i--)
                                        {
                                            categoryCb.Items.RemoveAt(i);
                                        }
                                        updatingTitle.Visible = false;
                                        bookTitle.Visible = true;
                                        label9.Visible = false;
                                        newBook.Visible = false;
                                        bookPublishers();
                                        bookCategories();
                                        loadBooks();
                                    }

                                }
                            }
                            else //Selected Category from CB
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("UPDATE books SET book_title = @btitle, publisher_id = @bpublisher, category_id = @bcateg, booktype_id = @btype WHERE book_id = @bid", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@bid", bookId.Text);
                                cmd.Parameters.AddWithValue("@btitle", updatingTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Updated Successfully", "Success");
                                    updatingTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    updatingTitle.Visible = false;
                                    bookTitle.Visible = true;
                                    label9.Visible = false;
                                    newBook.Visible = false;
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                    }
                    else //Chosen Existing Publisher from CB
                    {
                        if (categoryTxt.Text == "Existing Category?") // Creating new category but chosem existing Publisher
                        {
                            dbConnect.CloseConnection();
                            dbConnect = new Conclass();
                            dbConnect.OpenConnection();
                            MySqlCommand cmd3 = new MySqlCommand("SELECT * FROM categories WHERE category_name = @categName", dbConnect.myconnect);
                            cmd3.Parameters.AddWithValue("@categName", bookCategory.Text);
                            myReader = cmd3.ExecuteReader();
                            if (myReader.Read())
                            {
                                MessageBox.Show("Category Already Exist!", "Notice!");
                                dbConnect.CloseConnection();
                            }
                            else
                            {
                                newCategory();
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("UPDATE books SET book_title = @btitle, publisher_id = @bpublisher, category_id = @bcateg, booktype_id = @btype WHERE book_id = @bid", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@bid", bookId.Text);
                                cmd.Parameters.AddWithValue("@btitle", updatingTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Updated Successfully", "Success");
                                    updatingTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    updatingTitle.Visible = false;
                                    bookTitle.Visible = true;
                                    label9.Visible = false;
                                    newBook.Visible = false;
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                        else // Chosen existing Publisher and category
                        {
                            dbConnect = new Conclass();
                            dbConnect.OpenConnection();
                            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM books WHERE book_id = @bid AND book_title = @btitle AND publisher_id = @bpublisher AND category_id = @bcateg AND booktype_id = @btype", dbConnect.myconnect);
                            cmd1.Parameters.AddWithValue("@bid", bookId.Text);
                            cmd1.Parameters.AddWithValue("@btitle", updatingTitle.Text);
                            cmd1.Parameters.AddWithValue("@bpublisher", publisherID);
                            cmd1.Parameters.AddWithValue("@bcateg", categoryID);
                            cmd1.Parameters.AddWithValue("@btype", booktypeID);
                            myReader = cmd1.ExecuteReader();
                            if (myReader.Read())
                            {
                                MessageBox.Show("Book Already Exist!", "Notice!");
                                dbConnect.CloseConnection();
                            }
                            else
                            {
                                dbConnect.CloseConnection();
                                dbConnect = new Conclass();
                                dbConnect.OpenConnection();
                                MySqlCommand cmd = new MySqlCommand("UPDATE books SET book_title = @btitle, publisher_id = @bpublisher, category_id = @bcateg, booktype_id = @btype WHERE book_id = @bid", dbConnect.myconnect);
                                cmd.Parameters.AddWithValue("@bid", bookId.Text);
                                cmd.Parameters.AddWithValue("@btitle", updatingTitle.Text);
                                cmd.Parameters.AddWithValue("@bpublisher", publisherID);
                                cmd.Parameters.AddWithValue("@bcateg", categoryID);
                                cmd.Parameters.AddWithValue("@btype", booktypeID);
                                int num1 = cmd.ExecuteNonQuery();
                                if (num1 > 0)
                                {
                                    MessageBox.Show("Book Updated Successfully", "Success");
                                    updatingTitle.Clear();
                                    bookCategory.Clear();
                                    bookPublisher.Clear();
                                    publisherCb.SelectedIndex = 0;
                                    categoryCb.SelectedIndex = 0;
                                    bookTypeCb.SelectedIndex = 0;
                                    timer1.Start();
                                    int pub = publisherCb.Items.Count;
                                    int categ = categoryCb.Items.Count;
                                    for (int i = pub - 1; i > 0; i--)
                                    {
                                        publisherCb.Items.RemoveAt(i);
                                    }
                                    for (int i = categ - 1; i > 0; i--)
                                    {
                                        categoryCb.Items.RemoveAt(i);
                                    }
                                    updatingTitle.Visible = false;
                                    bookTitle.Visible = true;
                                    label9.Visible = false;
                                    newBook.Visible = false;
                                    bookPublishers();
                                    bookCategories();
                                    loadBooks();
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Book Doesn't Exist in the System Please Insert it First", "Notice!");
                }
            }
        }
        private void deleteBook_Click(object sender, EventArgs e)
        {
            if (bookId.TextLength == 0)
            {
                MessageBox.Show("Book doesn't exist in the system!", "Notice!");
            }
            else if (MessageBox.Show("Are you sure you want to delete this book?", "Notice!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dbConnect.CloseConnection();
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM book_transactions WHERE book_id = @tId", dbConnect.myconnect);
                cmd1.Parameters.AddWithValue("@tId", bookId.Text);
                myReader = cmd1.ExecuteReader();
                if (myReader.Read())
                {
                    MessageBox.Show("Cannot delete book, It hasn't still been returned", "Notice!");
                }
                else
                {
                    dbConnect.CloseConnection();
                    dbConnect = new Conclass();
                    dbConnect.OpenConnection();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM books WHERE book_id = @bid", dbConnect.myconnect);
                    cmd.Parameters.AddWithValue("@bid", bookId.Text);
                    int no = cmd.ExecuteNonQuery();
                    if (no > 0)
                    {
                        MessageBox.Show("Book Successfully Deleted!", "Notice!");
                        Form1.instance.manageBook_Click(null, null);
                    }
                }
            }
            else
            {
                return;
            }
        }
        #endregion

        #region ComboBoxes
        private void publisherCb_SelectedValueChanged(object sender, EventArgs e)
        {
            searchPublisher.Text = publisherCb.SelectedItem.ToString();
            readPublisher(searchPublisher);
        }

        private void categoryCb_SelectedValueChanged(object sender, EventArgs e)
        {
            searchCategory.Text = categoryCb.SelectedItem.ToString();
            readCategory(searchCategory);
        }

        private void bookTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT booktype_id FROM book_types WHERE booktype_desc = @btype", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@btype", bookTypeCb.SelectedItem);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                booktypeID = myReader["booktype_id"].ToString();
            }
            dbConnect.CloseConnection();
        }

        #endregion

        #region New Data
        private void newPublisher()
        {
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO publishers VALUES ('', @pubname)", dbConnect.myconnect);
            cmd1.Parameters.AddWithValue("@pubname", bookPublisher.Text);
            cmd1.ExecuteNonQuery();
            searchPublisher.Text = bookPublisher.Text;
            readPublisher(searchPublisher);
        }
        private void newCategory()
        {
            dbConnect.CloseConnection();
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd1 = new MySqlCommand("INSERT INTO categories VALUES ('', @categName)", dbConnect.myconnect);
            cmd1.Parameters.AddWithValue("@categName", bookCategory.Text);
            cmd1.ExecuteNonQuery();
            searchCategory.Text = bookCategory.Text;
            readCategory(searchCategory);
        }
        #endregion

        #region form Data
        private void bookTitle_TextChanged(object sender, EventArgs e)
        {
            if(bookTitle.TextLength < 1)
            {
                bookId.Clear();
            }
            else
            {
                dbConnect = new Conclass();
                dbConnect.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("SELECT book_id FROM books ORDER BY book_id DESC LIMIT 1", dbConnect.myconnect);
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    int num1 = myReader.GetInt32("book_id");
                    int num2 = num1 + 1;
                    bookId.Text = Convert.ToString(num2);
                }
                else
                {
                    bookId.Text = "1";
                }
            }
        }

        private void bookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bookDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            bookId.Clear();
            timer1.Stop();
        }
        #endregion

        #region Retrieved data
        private void bookCategories()
        {
            dbConnect= new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM categories", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                categoryCb.Items.Add(myReader["category_name"].ToString());
            }
        }
        private void bookPublishers()
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM publishers", dbConnect.myconnect);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                publisherCb.Items.Add(myReader["publisher_name"].ToString());
            }
        }
        private void readPublisher(Label searchPublisher)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT publisher_id FROM publishers WHERE publisher_name = @pname", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@pname", searchPublisher.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                publisherID = myReader["publisher_id"].ToString();
            }
            dbConnect.CloseConnection();
        }

        private void bookDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookCategory.Visible = false;
            categoryCb.Visible = true;
            categoryTxt.Text = "New Category?";
            categoryTxt.Location = new System.Drawing.Point(747, categoryTxt.Location.Y);
            bookPublisher.Visible = false;
            publisherCb.Visible = true;
            publisherTxt.Text = "New Publisher?";
            publisherTxt.Location = new System.Drawing.Point(288, publisherTxt.Location.Y);
            newBook.Visible = true;
            label9.Visible = true;
            updatingTitle.Visible = true;
            bookTitle.Visible = false;
            publisherCb.SelectedIndex = 0;
            categoryCb.SelectedIndex = 0;
            bookTypeCb.SelectedIndex = 0;
            updatingTitle.Text = bookDgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            bookDate.Text = bookDgv.Rows[e.RowIndex].Cells[3].Value.ToString();
            publisherCb.SelectedItem = bookDgv.Rows[e.RowIndex].Cells[2].Value.ToString();
            categoryCb.SelectedItem = bookDgv.Rows[e.RowIndex].Cells[4].Value.ToString();
            bookTypeCb.SelectedItem = bookDgv.Rows[e.RowIndex].Cells[5].Value.ToString();
            bookId.Text = bookDgv.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void readCategory(Label searchCategory)
        {
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT category_id FROM categories WHERE category_name = @cname", dbConnect.myconnect);
            cmd.Parameters.AddWithValue("@cname", searchCategory.Text);
            myReader = cmd.ExecuteReader();
            if (myReader.Read())
            {
                categoryID = myReader["category_id"].ToString();
            }
            dbConnect.CloseConnection();
        }
        private void loadBooks()
        {
            bookDgv.RowTemplate.Height = 30;
            bookDgv.ReadOnly = true;
            dbConnect = new Conclass();
            dbConnect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand("SELECT books.book_id, books.book_title, publishers.publisher_name, books.date_added, categories.category_name, book_types.booktype_desc FROM books RIGHT JOIN publishers ON books.publisher_id = publishers.publisher_id RIGHT JOIN categories ON books.category_id = categories.category_id RIGHT JOIN book_types ON books.booktype_id = book_types.booktype_id GROUP BY books.book_id ASC", dbConnect.myconnect);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            bookDgv.DataSource = dt;
            dbConnect.CloseConnection();
        }
        #endregion
    }
}
