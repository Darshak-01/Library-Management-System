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

namespace Library_project
{
    public partial class view_book : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public view_book()
        {
            InitializeComponent();
        }

        private void view_book_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
            getdata();

        }
        public void getdata()
        {
            cmd = new SqlCommand("select book_number as 'Book Number',book_name as 'Book Name',book_author as 'Book Author',book_quntity as 'Book Qntity',book_price as 'Book Price',c_date as 'Date' from add_new_book", con);
            SqlDataReader dr= cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
