using LiberarySystem.LiberaryClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LiberarySystem
{
    public partial class AdminView : Form
    {
        private int adminid;
        dbconnect c = new dbconnect();
        public AdminView(int adminid)
        {
            
            InitializeComponent();
            this.adminid = adminid;
            showbooks();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtboxCategory.Text == "" || txtboxYear.Text == "" || txtBoxauthorid.Text == "" || txtboxNumOfPages.Text == "" || txtboxTitle.Text == "" || textboxpublisher.Text == "")
            {
                MessageBox.Show("can`t delete till complete the validation");
            }
            if (istext(txtboxTitle.Text) == false)
            {
                MessageBox.Show("please write the title correctly");
                return;
            }
            if (istext(textboxpublisher.Text) == false)
            {
                MessageBox.Show("please write the publisher correctly");
                return;
            }
            if (istext(txtBoxauthorid.Text) == false)
            {
                MessageBox.Show("please write the author correctly");
                return;
            }
            if (IsNumeric(txtboxNumOfPages.Text) == false)
            {
                MessageBox.Show("please write number of pages correctly");
                return;
            }
            if (IsNumeric(txtboxYear.Text) == false)
            {
                MessageBox.Show("please write year correctly");
                return;
            }
            if (clickedCell != null)
            {


                string ueo = "declare @bookid int \r\nset @bookid=@ISBN\r\ndeclare @class int\r\nselect @class=category.classificationCode from category join book on book.categoryId=category.classificationCode  where book.ISBN=@bookid\r\nupdate category set BooksCount=BooksCount-1 where classificationCode=@class ";
                SqlCommand cmdmm = new SqlCommand(ueo, c.getcon());
                c.opencon();
                cmdmm.Parameters.AddWithValue("@ISBN", txtboxISBN.Text);
                cmdmm.ExecuteNonQuery();
                c.closecon();
                string q = "delete from book  where ISBN=@ISBN";
                SqlCommand cmd = new SqlCommand(q, c.getcon());
                c.opencon();
                cmd.Parameters.AddWithValue("@ISBN", txtboxISBN.Text);
                cmd.ExecuteNonQuery();
                c.closecon();


                MessageBox.Show("deleted succesfully");

                showbooks();
                txtboxISBN.Text = "";
                txtboxCategory.Text = "";
                txtBoxauthorid.Text = "";
                txtboxNumOfPages.Text = "";
                txtboxYear.Text = "";
                txtboxTitle.Text = "";
                textboxpublisher.Text = "";

            }
            else
            {
                MessageBox.Show("you should click on the row you wan to delete");
                return;
            }
        }

           
   
              
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }

        private void AdminView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ezzDataSet1.book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.ezzDataSet1.book);
            // TODO: This line of code loads data into the 'ezzDataSet.book' table. You can move, or remove it, as needed.

            //this.bookTableAdapter.Fill(this.ezzDataSet.book);

        }



        /*
         create table book
(
  ISBN varchar(30) primary key,
  Tittle varchar(30) not null , 
  numOfPage varchar(30) not null , 
  categoryId varchar(30) not null,
  authorId varchar(30) not null,
  publisherId varchar(30) not null,
  adminId int  not null,
  
  )

         
         */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtboxCategory.Text == "" || txtboxYear.Text == "" || txtBoxauthorid.Text == "" || txtboxNumOfPages.Text == "" || txtboxTitle.Text == "" || textboxpublisher.Text == "")
            {
                MessageBox.Show("can`t add till complete the validation");
                return;
            }
            txtboxISBN.Text = "";
            if (istext(textboxpublisher.Text) == false)
            {
                MessageBox.Show("please write the publisher correctly");
                return;
            }
            if (istext(txtBoxauthorid.Text) == false)
            {
                MessageBox.Show("please write the author correctly");
                return;
            }

            if (istext(txtboxCategory.Text) == false)
            {
                MessageBox.Show("please write the catagory correctly");
                return;
            }
            if (IsNumeric(txtboxNumOfPages.Text) == false)
            {
                MessageBox.Show("please write number of pages correctly");
                return;
            }
            if (IsNumeric(txtboxYear.Text) == false)
            {
                MessageBox.Show("please write year correctly");
                return;
            }
            string title = "SELECT count(Tittle) FROM book WHERE Tittle = @Tittle;";
            c.opencon();
            SqlCommand cir = new SqlCommand(title, c.getcon());
            cir.Parameters.Add(new SqlParameter("@Tittle", txtboxTitle.Text));
            int titlel = Convert.ToInt32(cir.ExecuteScalar());
            c.closecon();
            if (titlel >0)
            {
                MessageBox.Show("this book is already exist");

            }
            else
            {
                try
                {
                    string q = "SELECT classificationCode FROM category WHERE [name] = @name;";
                    c.opencon();
                    SqlCommand cd = new SqlCommand(q, c.getcon());
                    cd.Parameters.Add(new SqlParameter("@name", txtboxCategory.Text));
                    int categoryId = Convert.ToInt32(cd.ExecuteScalar());
                    c.closecon();

                    if (categoryId > 0)
                    {
                        string ksk = "SELECT BooksCount FROM category WHERE classificationCode = @classificationCode;";
                        c.opencon();
                        SqlCommand cmd9 = new SqlCommand(ksk, c.getcon());
                        cmd9.Parameters.AddWithValue("@classificationCode", categoryId);
                        int countcat = Convert.ToInt32(cmd9.ExecuteScalar());
                        countcat++;

                        string mk = "UPDATE category SET BooksCount = @BooksCount WHERE classificationCode = @classificationCode;";
                        SqlCommand ck = new SqlCommand(mk, c.getcon());
                        ck.Parameters.Add(new SqlParameter("@classificationCode", categoryId));
                        ck.Parameters.Add(new SqlParameter("@BooksCount", countcat));
                        ck.ExecuteNonQuery();
                        c.closecon();
                    }


                    else
                    {
                        c.opencon();
                        string mm = "insert into category ([name],BooksCount)values(@name,@BooksCount)";
                        SqlCommand cmd10 = new SqlCommand(mm, c.getcon());
                        cmd10.Parameters.Add(new SqlParameter("@name", txtboxCategory.Text));
                        cmd10.Parameters.Add(new SqlParameter("@BooksCount", 1));
                        cmd10.ExecuteNonQuery();
                        string l = "select max(classificationCode) from category  ";
                        SqlCommand cmd5 = new SqlCommand(l, c.getcon());
                        cmd5.ExecuteNonQuery();
                        categoryId = Convert.ToInt32(cmd5.ExecuteScalar());
                        c.closecon();
                    }

                    c.opencon();
                    string x = "select id from publisher where [Name] =@name;";
                    SqlCommand cdd = new SqlCommand(x, c.getcon());
                    cdd.Parameters.Add(new SqlParameter("@name", textboxpublisher.Text));
                    SqlDataAdapter adapter = new SqlDataAdapter(cdd);
                    DataTable pt = new DataTable();
                    adapter.Fill(pt);
                    int publisherId;
                    if ((pt.Rows.Count == 0))
                    {
                        c.opencon();
                        string z = "insert into publisher([name])values(@name)";
                        SqlCommand cmd6 = new SqlCommand(z, c.getcon());
                        cmd6.Parameters.Add(new SqlParameter("@name", textboxpublisher.Text));
                        cmd6.ExecuteNonQuery();
                        c.closecon();
                        string l = "select max(id) from publisher  ";
                        SqlCommand cmd5 = new SqlCommand(l, c.getcon());
                        c.opencon();
                        cmd5.ExecuteNonQuery();
                        publisherId = Convert.ToInt32(cmd5.ExecuteScalar());
                        c.closecon();
                    }
                    else
                    {
                        publisherId = Convert.ToInt32(cdd.ExecuteScalar());
                        c.closecon();
                    }


                    c.opencon();
                    string a = "select id from author where [Name] =@name;";
                    SqlCommand cmd3 = new SqlCommand(a, c.getcon());
                    cmd3.Parameters.Add(new SqlParameter("@name", txtBoxauthorid.Text));
                    int authorId;
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd3);
                    DataTable dt = new DataTable();
                    adapt.Fill(dt);

                    if ((dt.Rows.Count == 0))
                    {
                        string z = "insert into author([name] ,nationality)values(@name,@nation)";
                        SqlCommand cmd4 = new SqlCommand(z, c.getcon());
                        cmd4.Parameters.Add(new SqlParameter("@name", txtBoxauthorid.Text));
                        cmd4.Parameters.Add(new SqlParameter("@nation", "egypt"));
                        cmd4.ExecuteNonQuery();
                        c.closecon();

                        string l = "select max(id) from author";
                        SqlCommand cmd5 = new SqlCommand(l, c.getcon());
                        c.opencon();
                        cmd5.ExecuteNonQuery();
                        authorId = Convert.ToInt32(cmd5.ExecuteScalar());
                        c.closecon();
                    }
                    else
                    {
                        authorId = Convert.ToInt32(cmd3.ExecuteScalar());
                        c.closecon();
                    }




                    string query = "INSERT INTO book(Tittle,numOfPage,categoryId,publisherId,adminId,Year,authorId) values(@Tittle,@numOfPage,@categoryId,@publisherId,@adminId,@Year,@authorId)";
                    SqlCommand cmd = new SqlCommand(query, c.getcon());
                    c.opencon();

                    // cmd.Parameters.Add(new SqlParameter("@ISBN",txtboxISBN.Text));
                    cmd.Parameters.Add(new SqlParameter("@Tittle", txtboxTitle.Text));
                    cmd.Parameters.Add(new SqlParameter("@numOfPage", txtboxNumOfPages.Text));
                    cmd.Parameters.Add(new SqlParameter("@categoryId", categoryId));
                    cmd.Parameters.Add(new SqlParameter("@publisherId", publisherId));
                    cmd.Parameters.Add(new SqlParameter("@adminId", adminid));
                    cmd.Parameters.Add(new SqlParameter("@Year", txtboxYear.Text));
                    cmd.Parameters.Add(new SqlParameter("@authorId", authorId));
                    cmd.ExecuteNonQuery();
                    showbooks();

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
        }

        private void txtboxISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblISBN_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textboxpublisher_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbladminid_Click(object sender, EventArgs e)
        {

        }
        public void showbooks() //
        {
            try
            {

                string q = "select * from v2";
                    

                c.opencon();
                SqlCommand cmd = new SqlCommand(q, c.getcon());
                SqlDataAdapter add = new SqlDataAdapter(cmd);
                DataTable tt = new DataTable();
                add.Fill(tt);
                dataGridViewbooks.DataSource = tt;
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
        DataGridViewCell clickedCell;
        private void dataGridViewbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Store the clicked cell
                clickedCell = dataGridViewbooks.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            DataGridViewRow ro = dataGridViewbooks.Rows[e.RowIndex];
            txtboxISBN.Text = ro.Cells[0].Value.ToString();
            txtboxTitle.Text = ro.Cells[1].Value.ToString();
            txtboxNumOfPages.Text = ro.Cells[2].Value.ToString();
            txtboxYear.Text = ro.Cells[3].Value.ToString();
            txtBoxauthorid.Text = ro.Cells[4].Value.ToString();
            textboxpublisher.Text = ro.Cells[5].Value.ToString();
            txtboxCategory.Text = ro.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtboxCategory.Text == "" || txtboxYear.Text == "" || txtBoxauthorid.Text == "" || txtboxNumOfPages.Text == "" || txtboxTitle.Text == "" || textboxpublisher.Text == "")
            {
                MessageBox.Show("can`t update till complete the validation");
            }
            if (istext(txtboxTitle.Text) == false)
            {
                MessageBox.Show("please write the title correctly");
                return;
            }
            if (istext(textboxpublisher.Text) == false)
            {
                MessageBox.Show("please write the publisher correctly");
                return;
            }
            if (istext(txtBoxauthorid.Text) == false)
            {
                MessageBox.Show("please write the author correctly");
                return;
            }
            if (IsNumeric(txtboxNumOfPages.Text) == false)
            {
                MessageBox.Show("please write number of pages correctly");
                return;
            }
            if (IsNumeric(txtboxYear.Text) == false)
            {
                MessageBox.Show("please write year correctly");
                return;
            }
            if (clickedCell != null)
            {
                
                string au = " declare @id int  select @id=book.authorId from book join author on book.authorId=author.id where ISBN=@IS \r\nupdate author set [Name]=@aunam where id=@id ";
                SqlCommand cmdls = new SqlCommand(au, c.getcon());
                c.opencon();
                cmdls.Parameters.AddWithValue("@IS", txtboxISBN.Text);
                cmdls.Parameters.AddWithValue("@aunam", txtBoxauthorid.Text);
                cmdls.ExecuteNonQuery();
                c.closecon();
                string pub = "declare @id_au int select @id_au=book.publisherId from book join publisher on book.publisherId=publisher.id where ISBN=@bookid \r\nupdate publisher set [Name]=@pubi where id=@id_au ";
                SqlCommand cmdlsk = new SqlCommand(pub, c.getcon());
                c.opencon();
                cmdlsk.Parameters.AddWithValue("@bookid", txtboxISBN.Text);
                cmdlsk.Parameters.AddWithValue("@pubi", textboxpublisher.Text);
                cmdlsk.ExecuteNonQuery();
                c.closecon();
                string cat = "declare @id_ct int select @id_ct=book.categoryId from book join category on book.categoryId=category.classificationCode where ISBN=@book \r\nupdate category set [Name]=@cat where classificationCode=@id_ct";
                SqlCommand cmdlskm = new SqlCommand(cat, c.getcon());
                c.opencon();
                cmdlskm.Parameters.AddWithValue("@book", txtboxISBN.Text);
                cmdlskm.Parameters.AddWithValue("@cat", txtboxCategory.Text);
                cmdlskm.ExecuteNonQuery();
                c.closecon();
                string q = "update book set Tittle=@Tittle,  numOfPage=@numOfPage, Year=@Year where ISBN=@ISBN";
                SqlCommand cmd = new SqlCommand(q, c.getcon());
                c.opencon();
                cmd.Parameters.AddWithValue("@ISBN", txtboxISBN.Text);
                cmd.Parameters.AddWithValue("@Tittle", txtboxTitle.Text);
                cmd.Parameters.AddWithValue("@numOfPage", txtboxNumOfPages.Text);
                cmd.Parameters.AddWithValue("@Year", txtboxYear.Text);
                cmd.ExecuteNonQuery();
                c.closecon();
                MessageBox.Show("updated succesfully");
                showbooks();

            }
            else
            {
                MessageBox.Show("you should click on the row you would to update");
                return;
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

            dataGridViewbooks.DataSource = table;
            c.closecon();
        }
        public bool istext(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                    return false;
            }
            return true;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy(this.ezzDataSet.book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void waiting_Click(object sender, EventArgs e)
        {
            waitinglist wait=new waitinglist();
            wait.Show();
            this.Hide();
        }

        private void txtBoxauthorid_TextChanged(object sender, EventArgs e)
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

    
