using LiberarySystem.LiberaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberarySystem
{
    public partial class SignIn : Form
    {
    dbconnect dbm = new dbconnect();
        
        LogIn logIn = new LogIn();

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            
            logIn.Email = txtboxEmail.Text;
            logIn.Password = txtboxPassword.Text;
            logIn.CheckAdminOrStudent = chkboxAdmin.Checked;


            if(logIn.CheckAdminOrStudent == true)
            {
                string s = "select id from admin where [email]=@email and pass=@pass";
                SqlCommand cmd = new SqlCommand(s, dbm.getcon());
                cmd.Parameters.Add(new SqlParameter("@email", logIn.Email));
                cmd.Parameters.Add(new SqlParameter("@pass", logIn.Password));
                dbm.opencon();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("a");
                    int adminid;
                    adminid=Convert.ToInt32(cmd.ExecuteScalar());
                    AdminView adminView = new AdminView(adminid);
                    adminView.Show();
                }
                else
                {
                    MessageBox.Show("wrong");
                }
               
            }
            else
            {
                string s = "select id from student where [email]=@email and pass=@pass";
                SqlCommand cmd = new SqlCommand(s, dbm.getcon());
                dbm.opencon();
                cmd.Parameters.Add(new SqlParameter("@email", logIn.Email));
                cmd.Parameters.Add(new SqlParameter("@pass", logIn.Password));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                int userid;
                userid =Convert.ToInt32(cmd.ExecuteScalar());
                dbm.closecon();
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("succes");
                    StudentView adminView = new StudentView(userid);
                    adminView.Show();
                }
                else
                {
                    MessageBox.Show("wrong");
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBooks books = new LibraryBooks();
            books.Show();
            this.Hide();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
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
