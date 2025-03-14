using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberarySystem
{
    public partial class LibraryBooks : Form
    {
        public LibraryBooks()
        {
            InitializeComponent();
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //create new form should I go to
            Type type = new Type();
            type.Show();
            this.Hide();
            
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //create new form should I go to
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();            
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LibraryBooks_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
                    }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void btnMadeBy_Click(object sender, EventArgs e)
        {
            MadeBy madeBy = new MadeBy();
            madeBy.Show();
            this.Hide();
        }
    }
}
