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
    public partial class waitinglist : Form
    {
        dbconnect db=new dbconnect();
        public waitinglist()
        {
            InitializeComponent();
            showwait();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showwait()
        {
            string q = "select * from v3";
            SqlCommand cmd = new SqlCommand(q, db.getcon());
            db.opencon();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewwait.DataSource = dt;
            db.closecon();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            LibraryBooks libraryBooks = new LibraryBooks();
            libraryBooks.Show();
            this.Hide();
        }
    }
}
