using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Book_borrowing
{
    internal class Conclass
    {
        public MySqlConnection myconnect;

        public Conclass()
        {
            Initialize();
        }
        public void Initialize()
        {
            string connectionString;
            connectionString = "Server=localhost; Database=book_management; Port=3306; User=root; Password=''";
            myconnect = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                myconnect.Open();
                //MessageBox.Show("Successfully Connected");
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                myconnect.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
