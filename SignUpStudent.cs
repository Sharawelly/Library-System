using LiberarySystem.LiberaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace LiberarySystem
{
    public partial class SignUpStudent : Form
    {
        public SignUpStudent()
        {
            InitializeComponent();
        }

        dbconnect con= new dbconnect();
        
       




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSecondName_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        Student std = new Student();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            std.Name = txtboxFirstName.Text;
            std.Password = txtboxPassword.Text;
            std.Email = txtboxEmail.Text;
            std.PasswordAgain = txtAgainPassword.Text;
            std.SecondName = txtboxSecondName.Text;
            std.LastName = txtboxLastName.Text;
            std.Gender = cmbboxGender.Text;
            if (check())
            {

                try
                {

                    string query = "INSERT INTO student( fname ,mname ,lname ,email ,pass , gender) values(@fname ,@mname ,@lname ,@email ,@pass ,@gender)";
                    SqlCommand cmd = new SqlCommand(query, con.getcon());
                    //cmd.Parameters.Add(new SqlParameter("@id", std.getid()));
                    cmd.Parameters.Add(new SqlParameter("@fname", txtboxFirstName.Text));
                    cmd.Parameters.Add(new SqlParameter("@mname", txtboxSecondName.Text));
                    cmd.Parameters.Add(new SqlParameter("@lname", txtboxLastName.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", txtboxEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@pass", txtboxPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@gender", cmbboxGender.Text));
                    con.opencon();
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    con.closecon();
                }
                LibraryBooks lib = new LibraryBooks();
                lib.Show();
                this.Hide();
            }
            else
            {
                return; 
            }

        }
        public bool check()
        {
            if (!std.Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("email should end with @gmail.com");
                return false;
            }
            string s = "select count(id) from student where email=@email ";
            SqlCommand cmd =new SqlCommand(s, con.getcon());
            cmd.Parameters.AddWithValue("@email",std.Email);
            con.opencon();
            int is_exist=Convert.ToInt32(cmd.ExecuteScalar());
            if(is_exist > 0)
            {
                MessageBox.Show("this email used before try another email");
                return false;
            }
            string ezz = "select count(id) from student where pass=@pass ";
            SqlCommand cmdk = new SqlCommand(ezz, con.getcon());
            cmdk.Parameters.AddWithValue("@pass", std.Password);
            con.opencon();
            int is_exis = Convert.ToInt32(cmdk.ExecuteScalar());
            if (is_exis > 0)
            {
                MessageBox.Show("this password used before try another password");
                return false;
            }
            if (std.Password.Length < 8)
            {
                MessageBox.Show("Invalid Password the Password should be less than 8 values");
                txtboxPassword.Clear();
                return false;
            }
            if (!std.Email.Contains('@'))
            {
                MessageBox.Show("Invalid Email the Email should contains @");
                txtboxEmail.Clear();
                return false;
            }
            if (std.PasswordAgain != std.Password)
            {
                MessageBox.Show("Two Password aren't the same");
                txtAgainPassword.Clear();
                return false;
            }

            if(std.Name == "" || std.Password == "" || std.PasswordAgain == "" || std.Gender == "" || std.Email == "" || std.SecondName == "" || std.LastName == "")
            {
                MessageBox.Show("Required Field is Empty!");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Type type = new Type();
            type.Show();
            this.Hide();
        }

        private void txtboxStudentId_TextChanged(object sender, EventArgs e)
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
