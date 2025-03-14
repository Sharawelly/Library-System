using LiberarySystem.LiberaryClasses;
using LiberarySystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberarySystem
{

    public partial class StudentView : Form
    {
        private int userid;
        dbconnect c = new dbconnect();
        public StudentView(int uderid)
        {
            InitializeComponent();
            this.userid = uderid;
            showbooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ro = dataGridView1.Rows[e.RowIndex];
            textBoxbookid.Text = ro.Cells[0].Value.ToString();


        }
        public void showbooks()
        {
            try
            {

                string q = "select * from v2";


                c.opencon();
                SqlCommand cmd = new SqlCommand(q, c.getcon());
                SqlDataAdapter add = new SqlDataAdapter(cmd);
                DataTable tt = new DataTable();
                add.Fill(tt);
                dataGridView1.DataSource = tt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

                c.closecon();
            }
        }
        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            string q = @"SELECT ISBN, Title, pages, year, authorname, publishername,category
                 FROM v2 
                 WHERE ISBN = @ISBN 
                    OR pages = @numOfPage  
                    OR authorname LIKE @authorId 
                    OR publishername LIKE @publisherId
                    OR category LIKE @category
                    OR Year = @Year
                    OR Title LIKE @Tittle";

            SqlCommand cmd = new SqlCommand(q, c.getcon());
            c.opencon();
            int intSearchValue;
            if (int.TryParse(txtboxSearch.Text, out intSearchValue))
            {
                cmd.Parameters.AddWithValue("@ISBN", intSearchValue);
                cmd.Parameters.AddWithValue("@numOfPage", intSearchValue);
                cmd.Parameters.AddWithValue("@Year", intSearchValue);
            }
            else
            {
                cmd.Parameters.AddWithValue("@ISBN", DBNull.Value);
                cmd.Parameters.AddWithValue("@numOfPage", DBNull.Value);
                cmd.Parameters.AddWithValue("@Year", DBNull.Value);
            }

            cmd.Parameters.AddWithValue("@Tittle", "%" + txtboxSearch.Text + "%");
            cmd.Parameters.AddWithValue("@category", "%" + txtboxSearch.Text + "%");
            cmd.Parameters.AddWithValue("@publisherId", "%" + txtboxSearch.Text + "%");
            cmd.Parameters.AddWithValue("@authorId ", "%" + txtboxSearch.Text + "%");




            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            c.closecon();
        }
            private void addtowaitingbtn_Click(object sender, EventArgs e)

        {
            if (IsNumeric(textBoxbookid.Text) == false)
            {
                MessageBox.Show("please write ISBN correct");
                return;
            }
            string userexistQuery = "SELECT COUNT(bookId) FROM studRequest WHERE bookId= @bookId group by bookId";
            SqlCommand userexistCmd = new SqlCommand(userexistQuery, c.getcon());
            userexistCmd.Parameters.AddWithValue("@bookId", textBoxbookid.Text);
            c.opencon();
            int userexistCount = Convert.ToInt32(userexistCmd.ExecuteScalar());
            c.closecon();

            if (userexistCount == 0)
            {
                MessageBox.Show("You should borrow first to add on waitinglist.");
                return;
            }
            if (string.IsNullOrEmpty(textBoxbookid.Text))
            {
                MessageBox.Show("Please enter a book ID.");
                return;
            }
            if (BookExists() == true)
            {
                // Check if the book is already borrowed
                string watingCheckQuery = "SELECT count(*) FROM Watinglist WHERE studentId=@studentId and bookId=@bookId  group by studentId,bookId;";
                SqlCommand dnd = new SqlCommand(watingCheckQuery, c.getcon());
                dnd.Parameters.AddWithValue("@studentId", userid);
                dnd.Parameters.AddWithValue("@bookId", textBoxbookid.Text);
                c.opencon();
                int isBookBorrowed = Convert.ToInt32(dnd.ExecuteScalar());
                c.closecon();

                if (isBookBorrowed != 0)
                {
                    MessageBox.Show("This book is already on waitinglist.");
                    return;
                }
                string a = "select studentId,bookId from studrequest where studentId=@studid and bookId=@bookid;";
                SqlCommand cmd3 = new SqlCommand(a, c.getcon());
                c.opencon();
                cmd3.Parameters.AddWithValue("@studid", userid);
                cmd3.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
                DataTable dt = new DataTable();
                adapt.Fill(dt);


                string b = "select isbn from book where  isbn=@bookid;";
                SqlCommand cmdb = new SqlCommand(b, c.getcon());
                cmdb.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                SqlDataAdapter adaptb = new SqlDataAdapter(cmdb);
                DataTable dtb = new DataTable();
                adaptb.Fill(dtb);

                string k = "select id from student where  id=@userid;";
                SqlCommand cmdk = new SqlCommand(k, c.getcon());
                cmdk.Parameters.AddWithValue("@userid", userid);
                SqlDataAdapter adaptk = new SqlDataAdapter(cmdk);
                DataTable dtk = new DataTable();
                adaptk.Fill(dtk);


                if ((dt.Rows.Count != 0) && (dtb.Rows.Count != 0) && (dtk.Rows.Count != 0))
                {
                    string q = "insert into watinglist(studentid,bookid,daysleft)values(@studid,@bookid,@daysleft)";
                    SqlCommand cmd = new SqlCommand(q, c.getcon());

                    cmd.Parameters.AddWithValue("@studid", userid);
                    cmd.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                   // cmd.Parameters.AddWithValue("@date", getdate());
                    cmd.Parameters.AddWithValue("@daysleft", "14");
                    cmd.ExecuteNonQuery();
                    c.closecon();
                    MessageBox.Show("You have been added to waititng list for this book successfully!");
                    textBoxbookid.Text = "";

                }
                else if ((dt.Rows.Count == 0) && (dtb.Rows.Count != 0) && (dtk.Rows.Count != 0))
                {
                    MessageBox.Show("Book is available already!");
                    c.closecon();

                }
                else
                {
                    MessageBox.Show("invalid information!");
                    c.closecon();
                }
            }
            else
            {
                MessageBox.Show("the book is not added in the library");
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void borrowbookbtn_Click(object sender, EventArgs e)
        {
            if(IsNumeric(textBoxbookid.Text) == false)
            {
                MessageBox.Show("please write ISBN correct");
                return;
            }
            if (string.IsNullOrEmpty(textBoxbookid.Text))
            {
                MessageBox.Show("Please enter a book ID.");
                return;
            }
            if (BookExists() == true)
            {
                // Check if the book is already borrowed
                string borrowCheckQuery = "SELECT count(studentId) FROM studRequest WHERE studentId = @studentId AND stutes = 'pending';";
                SqlCommand borrowCheckCmd = new SqlCommand(borrowCheckQuery, c.getcon());
                borrowCheckCmd.Parameters.AddWithValue("@studentId", userid);
                c.opencon();
                int isBookBorrowed = Convert.ToInt32(borrowCheckCmd.ExecuteScalar());
                c.closecon();

                if (isBookBorrowed != 0)
                {
                    MessageBox.Show("you borrowed a book please return it to repaet the process of borrowing.");
                    return;
                }
                string userexistQuery = "SELECT COUNT(*) FROM studRequest WHERE studentId = @studentId AND stutes = 'pending';";
                SqlCommand userexistCmd = new SqlCommand(userexistQuery, c.getcon());
                userexistCmd.Parameters.AddWithValue("@studentId", userid);
                c.opencon();
                int userexistCount = Convert.ToInt32(userexistCmd.ExecuteScalar());
                c.closecon();

                if (userexistCount != 0)
                {
                    MessageBox.Show("You already have a pending book. Please return it before borrowing again.");
                    return;
                }


                // If the book is not borrowed, proceed to borrow it
                string borrowQuery = "INSERT INTO studRequest (studentId, bookId, stutes) VALUES (@studentId, @bookId, 'pending');";
                SqlCommand borrowCmd = new SqlCommand(borrowQuery, c.getcon());
                borrowCmd.Parameters.AddWithValue("@studentId", userid);
                borrowCmd.Parameters.AddWithValue("@bookId", textBoxbookid.Text);

                c.opencon();
                borrowCmd.ExecuteNonQuery();
                c.closecon();

                MessageBox.Show("Borrow process has been done successfully!");
                textBoxbookid.Text = "";
            }
            else
            {
                MessageBox.Show("this book is not library!!");
            }
        }
        private void returnbookbtn_Click(object sender, EventArgs e)
        {
            if (IsNumeric(textBoxbookid.Text) == false)
            {
                MessageBox.Show("please write ISBN correct");
                return;
            }
            if (string.IsNullOrEmpty(textBoxbookid.Text))
            {
                MessageBox.Show("Please enter a book ID.");
                return;
            }
            string query = "SELECT COUNT(bookId) FROM Watinglist WHERE bookId = @isbn;";
            SqlCommand cmd = new SqlCommand(query, c.getcon());
            cmd.Parameters.AddWithValue("@isbn", textBoxbookid.Text);
            c.opencon();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            c.closecon();
            if (count > 0)
            {
                if (BookExists() == true)
                {
                    string a = "select studentId,bookId from studrequest where studentId=@studid and bookId=@bookid;";
                    SqlCommand cmd3 = new SqlCommand(a, c.getcon());
                    c.opencon();
                    cmd3.Parameters.AddWithValue("@studid", userid);
                    cmd3.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);


                    string b = "select ISBN from book where ISBN =@bookid;";
                    SqlCommand cmdb = new SqlCommand(b, c.getcon());
                    cmdb.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                    SqlDataAdapter adaptb = new SqlDataAdapter(cmdb);
                    DataTable dtb = new DataTable();
                    adaptb.Fill(dtb);

                    string k = "select id from student where  id=@userid;";
                    SqlCommand cmdk = new SqlCommand(k, c.getcon());
                    cmdk.Parameters.AddWithValue("@userid", userid);
                    SqlDataAdapter adaptk = new SqlDataAdapter(cmdk);
                    DataTable dtk = new DataTable();
                    adaptk.Fill(dtk);


                    if ((dt.Rows.Count != 0) && (dtb.Rows.Count != 0) && (dtk.Rows.Count != 0))
                    {
                        c.opencon();

                        // Begin a transaction
                        SqlTransaction transaction = c.getcon().BeginTransaction();

                        try
                        {
                            // Delete from studRequest table
                            string deleteQuery1 = "DELETE FROM studRequest WHERE studentId=@studid AND bookId=@bookid";
                            SqlCommand cmd1 = new SqlCommand(deleteQuery1, c.getcon(), transaction);
                            cmd1.Parameters.AddWithValue("@studid", userid);
                            cmd1.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                            cmd1.ExecuteNonQuery();

                            // Delete from Watinglist table
                            string deleteQuery2 = "DELETE FROM Watinglist WHERE studentId=@studid AND bookId=@bookid";
                            SqlCommand cmd2 = new SqlCommand(deleteQuery2, c.getcon(), transaction);
                            cmd2.Parameters.AddWithValue("@studid", userid);
                            cmd2.Parameters.AddWithValue("@bookid", textBoxbookid.Text);
                            cmd2.ExecuteNonQuery();

                            // Commit the transaction if both deletes are successful
                            transaction.Commit();

                            // Close the connection
                            c.closecon();

                            // Show success message
                            MessageBox.Show("Return process has been done successfully!");
                        }
                        catch (Exception ex)
                        {
                            // If any error occurs, rollback the transaction to maintain data consistency
                            transaction.Rollback();

                            // Close the connection
                            c.closecon();

                            // Show error message
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }

                        // Clear the book ID textbox
                        textBoxbookid.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("invalid information!");
                        c.closecon();
                    }
                }
                else
                {
                    MessageBox.Show("this book is not in the library!!");
                }
            }
            else
            {
                MessageBox.Show("please add this book to wating list first");
            }
        }
    
            
        
    private bool BookExists()
    {
        // Assuming c is an instance of your SqlConnection object
        string query = "SELECT COUNT(*) FROM book WHERE ISBN = @isbn;";
        SqlCommand cmd = new SqlCommand(query, c.getcon());
        cmd.Parameters.AddWithValue("@isbn", textBoxbookid.Text);

        c.opencon();
        int count = Convert.ToInt32(cmd.ExecuteScalar());
        c.closecon();


        return count > 0;
    }
         public bool IsNumeric(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
             updateuserdetailscs up=new updateuserdetailscs(userid);
            up.Show();
            this.Hide();
        }

        private void textBoxbookid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }
    }
    }


