using LiberarySystem.LiberaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LiberarySystem.Properties
{
    public partial class updateuserdetailscs : Form
    {
        dbconnect db = new dbconnect();
        private int userid;
        public updateuserdetailscs(int userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8)
            {
                MessageBox.Show("Invalid Password. The password should be at least 8 characters long.");
                textBox1.Text = "";
                return;
            }

            string email = emailbox.Text;
            if (!email.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Invalid Email. The email should end with @gmail.com.");
                emailbox.Text = "";
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("At least one field is required!");
                return;
            }

            // Check if the new password is the same as the current one
            string userExistQuery = "SELECT COUNT(id) FROM student WHERE pass=@pass AND id=@id";
            SqlCommand userExistCmd = new SqlCommand(userExistQuery, db.getcon());
            userExistCmd.Parameters.AddWithValue("@pass", textBox1.Text);
            userExistCmd.Parameters.AddWithValue("@id", userid);
            db.opencon();
            int userExistCount = Convert.ToInt32(userExistCmd.ExecuteScalar());
            db.closecon();

            if (userExistCount != 0)
            {
                MessageBox.Show("The new password is already exist!");
                return;
            }

            // Check if the new email is the same as the current one
            string emailExistQuery = "SELECT COUNT(id) FROM student WHERE email=@email AND id=@id";
            SqlCommand emailExistCmd = new SqlCommand(emailExistQuery, db.getcon());
            emailExistCmd.Parameters.AddWithValue("@email", email);
            emailExistCmd.Parameters.AddWithValue("@id", userid);
            db.opencon();
            int emailExistCount = Convert.ToInt32(emailExistCmd.ExecuteScalar());
            db.closecon();

            if (emailExistCount != 0)
            {
                MessageBox.Show("The new email is already exist!");
                return;
            }

            // Update password if provided
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                string updatePasswordQuery = "UPDATE student SET pass=@pass WHERE id=@id";
                SqlCommand updatePasswordCmd = new SqlCommand(updatePasswordQuery, db.getcon());
                updatePasswordCmd.Parameters.AddWithValue("@pass", textBox1.Text);
                updatePasswordCmd.Parameters.AddWithValue("@id", userid);
                db.opencon();
                updatePasswordCmd.ExecuteNonQuery();
                db.closecon();
            }

            // Update email if provided
            if (!string.IsNullOrWhiteSpace(email))
            {
                string updateEmailQuery = "UPDATE student SET email=@email WHERE id=@id";
                SqlCommand updateEmailCmd = new SqlCommand(updateEmailQuery, db.getcon());
                updateEmailCmd.Parameters.AddWithValue("@email", email);
                updateEmailCmd.Parameters.AddWithValue("@id", userid);
                db.opencon();
                updateEmailCmd.ExecuteNonQuery();
                db.closecon();
            }

            MessageBox.Show("Your information has been updated successfully!");

        }
    }
}
