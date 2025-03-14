using LiberarySystem.LiberaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberarySystem
{
    public partial class SignUpAdmin : Form
    {
        public SignUpAdmin()
        {
            InitializeComponent();

        }

        dbconnect c = new dbconnect();

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

        Admin adm = new Admin();
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            adm.Name = txtboxUserName.Text;
            adm.Password = txtboxPassword.Text;
            adm.Email = txtboxEmail.Text;
            adm.PasswordAgain = txtAgainPassword.Text;
            adm.Role = txtboxRole.Text;
            adm.Department = txtboxDepartment.Text;
            adm.Gender = cmbboxGender.Text;
            
           

            if (check())
            {

                try
                {

                    string query = "INSERT INTO admin( name ,email ,pass  ,gender , role ,department) values(@name ,@email ,@pass ,@gender ,@role ,@department)";
                    SqlCommand cmd = new SqlCommand(query, c.getcon());
                    // cmd.Parameters.Add(new SqlParameter("@id", adm.getidd()));
                    cmd.Parameters.Add(new SqlParameter("@role", txtboxRole.Text));
                    cmd.Parameters.Add(new SqlParameter("@department", txtboxDepartment.Text));
                    cmd.Parameters.Add(new SqlParameter("@name", txtboxUserName.Text));
                    cmd.Parameters.Add(new SqlParameter("@email", txtboxEmail.Text));
                    cmd.Parameters.Add(new SqlParameter("@pass", txtboxPassword.Text));
                    cmd.Parameters.Add(new SqlParameter("@gender", cmbboxGender.Text));



                    c.opencon();

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    c.closecon();
                }
                //create new form should I go to
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
            if (!adm.Email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("email should end with @gmail.com");
                return false;
            }
            string s = "select count(id) from admin where email=@email ";
            SqlCommand cmd = new SqlCommand(s, c.getcon());
            cmd.Parameters.AddWithValue("@email", adm.Email);
            c.opencon();
            int is_exist = Convert.ToInt32(cmd.ExecuteScalar());
            if (is_exist > 0)
            {
                MessageBox.Show("this email used before try another email");
                return false;
            }
            string ezz = "select count(id) from admin where pass=@pass ";
            SqlCommand cmdk = new SqlCommand(ezz, c.getcon());
            cmdk.Parameters.AddWithValue("@pass", adm.Password);
            c.opencon();
            int is_exis = Convert.ToInt32(cmdk.ExecuteScalar());
            if (is_exis > 0)
            {
                MessageBox.Show("this password used before try another password");
                return false;
            }
            if (adm.Password.Length < 8)
            {
                MessageBox.Show("Invalid Password the Password should be more than 8 values");
                txtAgainPassword.Clear();
                return false;
            }
            if (!adm.Email.Contains('@'))
            {
                MessageBox.Show("Invalid Email the Email should contains @");
                txtboxEmail.Clear();
                return false;
            }
            if (adm.PasswordAgain != adm.Password)
            {
                MessageBox.Show("Two Password aren't the same");
                txtAgainPassword.Clear();
                return false;
            }

            if (adm.Name == "" || adm.Password == "" || adm.PasswordAgain == "" || adm.Gender == "" || adm.Email == "" || adm.Role == "" || adm.Department == "")

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

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
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
