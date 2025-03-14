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
    public partial class report : Form
    {
        dbconnect db=new dbconnect();
        public report()
        {
            InitializeComponent();
            showreport();
        }
        public void showreport()
        {
            string q = "select\r\n    b.Tittle as BookName,\r\n    c.Name as Category,\r\n    b.Year,\r\n    b.numOfPage,\r\n    STRING_AGG(concat(s.fname, ' ', s.lname), ', ') AS StudentNames,\r\n    p.Name as Publisher,\r\n    a.Name as Author,\r\n    count(Distinct sr.studentId) as StudentCount,\r\n    max(cat.BooksCount) as BooksInCategory\r\nfrom\r\n    book as b\r\njoin\r\n    category as c on b.categoryId = c.classificationCode\r\njoin\r\n    publisher as p on b.publisherId = p.id\r\njoin\r\n    author as a on b.authorId = a.id\r\njoin \r\n    studRequest as sr on b.ISBN = sr.bookId\r\njoin\r\n    student as s on sr.studentId = s.id\r\njoin \r\n    category as cat on c.Name = cat.Name\r\ngroup by \r\n    b.Tittle, c.Name, b.Year, b.numOfPage, p.Name, a.Name\r\n\r\n    order by count(sr.studentId) desc";



            SqlCommand cmd = new SqlCommand(q, db.getcon());
            db.opencon();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            db.closecon();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
