using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_project
{
    public partial class book_not_return : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public book_not_return()
        {
            InitializeComponent();
        }

        private void book_not_return_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
            getdata();
        }
        public void getdata()
        {
            DateTime dt1=new DateTime(2024,1,1);
            //cmd = new SqlCommand("select book_number as 'Book Number',book_name as 'Book Name',student_number as 'Roll Number' ,student_name as 'Student Name',return_in_date as 'Return Date' from giving_a_book where return_in_date between '"+dt1+"' and '"+DateTime.Now+"'", con);
            //cmd = new SqlCommand("select book_number as 'Book Number',book_name as 'Book Name',student_number as 'Roll Number' ,student_name as 'Student Name',return_in_date as 'Return Date' from giving_a_book where return_in_date between '"+dt1+"' and '"+DateTime.Now+"'", con);
            // cmd = new SqlCommand("select giving_a_book.book_number,giving_a_book.book_name,giving_a_book.student_number,giving_a_book.student_name,giving_a_book.return_in_date,add_student.mobile_number,add_student.stud_stream,add_student.stud_class from giving_a_book inner join add_student on giving_a_book.student_number=add_student.stud_rno(select * from giving_a_book where return_in_date between '"+dt1+"' and '"+DateTime.Now+"')", con);
            cmd = new SqlCommand("select giving_a_book.book_number as 'Book Number',giving_a_book.book_name as 'Book Name',giving_a_book.student_number as 'Student Number',giving_a_book.student_name as 'Student Name',giving_a_book.return_in_date as 'Return Date',add_student.mobile_number as 'Mobile Number',add_student.stud_stream as 'Student Stream',add_student.stud_class as 'Student Class' from giving_a_book inner join add_student on giving_a_book.student_number=add_student.stud_rno and return_in_date between '" + dt1 + "' and '" + DateTime.Now + "'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
