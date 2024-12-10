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
    public partial class stud_detail : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public stud_detail()
        {
            InitializeComponent();
        }

        private void stud_detail_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
            getdata();
        }
        public void getdata()
        {
            cmd = new SqlCommand("select stud_rno as 'Student Roll No',stud_name as 'Student Name',stud_spid as 'Student SP ID',stud_stream as 'Student Stream',stud_class as 'Student Class',mobile_number as 'Mobile Number',stud_address as 'Student Address' from add_student", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
