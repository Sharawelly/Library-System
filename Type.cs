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
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            //create new form should I go to
            SignUpStudent signUp = new SignUpStudent();
            signUp.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //create new form should I go to
            SignUpAdmin signUpAdmin = new SignUpAdmin();
            signUpAdmin.Show();
            this.Hide();
        }

        private void Type_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }
    }
}
