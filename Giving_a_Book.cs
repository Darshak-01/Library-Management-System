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
    public partial class Giving_a_Book : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Giving_a_Book()
        {
            InitializeComponent();
        }

        private void Giving_a_Book_Load(object sender, EventArgs e)
        {
            con=new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
            //dateTimePicker1.Enabled=false;
            //dateTimePicker2.Enabled=false;
            panel1.Hide();
        }

        private void book_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            String i=book_number.Text;
            if (e.KeyChar == 13)
            {
                if (i == "")
                {
                    MessageBox.Show("Palce Enter Value in Book Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("select book_name,book_quntity from add_new_book where book_number='" + Convert.ToInt16(book_number.Text) + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        int x=Convert.ToInt32(dr.GetValue(1));
                        if (x == 0)
                        {
                            MessageBox.Show("Book Quntity Is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            book_number.Clear();
                            book_number.Focus();
                        }
                        else
                        {
                            Book_name.Text = dr.GetValue(0).ToString();
                            book_qntity.Text = dr.GetValue(1).ToString();
                            Book_id_number.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Palce Enter Valid Book Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close(); 
                }
            }
        }

        private void student_number_KeyPress(object sender, KeyPressEventArgs e)
        {
             String s=student_number.Text;
             if (e.KeyChar == 13)
             {
                if (s == "")
                {
                    MessageBox.Show("Palce Enter Value in Student Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("select stud_name from add_student where stud_rno='" + Convert.ToInt16(student_number.Text) + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        student_name.Text = dr.GetValue(0).ToString();
                        return_days.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Palce Enter Valid Book Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                }
              }
        }

        private void return_days_KeyPress(object sender, KeyPressEventArgs e)
        {
            String s = return_days.Text;
            if (e.KeyChar == 13)
            {
                if (s == "")
                {
                    MessageBox.Show("Palce Enter Value in return days", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int return_days_book=Convert.ToInt16(return_days.Text);
                    DateTime date=DateTime.Now;
                    date=date.AddDays(return_days_book);
                    dateTimePicker2.Text = date.ToString();
                }
            }
        }

        private void Book_id_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                student_number.Focus();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            book_number.Clear();
            student_number.Clear();
            Book_id_number.Clear();
            return_days.Clear();
            Book_name.Text= string.Empty;   
            student_name.Text= string.Empty;
            book_number.Focus();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            
            if (book_number.Text==""|| student_number.Text==""||return_days.Text=="" || Book_id_number.Text=="")
            {
                MessageBox.Show("Place Enter Value In All Field.....!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int temp = Convert.ToInt32(book_number.Text);
                cmd = new SqlCommand("select book_id_number from giving_a_book where book_id_number='" + Convert.ToInt16(Book_id_number.Text) + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Place Enter Unique book ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Book_id_number.Clear();
                    Book_id_number.Focus();
                }
                else
                {
                    dr.Close();
                    int return_days_book = Convert.ToInt16(return_days.Text);
                    DateTime date = DateTime.Now;
                    date = date.AddDays(return_days_book);
                    //dateTimePicker2.Text = date.ToString();
                    cmd = new SqlCommand("insert into giving_a_book values('" + Convert.ToInt16(book_number.Text) + "','" + Book_name.Text + "','" + Convert.ToInt16(Book_id_number.Text) + "','" + Convert.ToInt16(student_number.Text) + "','" + student_name.Text + "','" + dateTimePicker1.Value.Date + "','" + Convert.ToInt16(return_days.Text) + "','" + dateTimePicker2.Value.Date + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Data Insert SuccessFulyy", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        book_number.Clear();
                        student_number.Clear();
                        Book_id_number.Clear();
                        return_days.Clear();
                        Book_name.Text = string.Empty;
                        student_name.Text = string.Empty;
                        Book_name.Text = "";
                        book_qntity.Text = "";
                        book_number.Focus();
                    }
                    cmd = new SqlCommand("update add_new_book set book_quntity=book_quntity-1 where book_number='"+temp+"'", con);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void Show_data_Click(object sender, EventArgs e)
        {
            panel1.Show();
            getdata();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }
        public void getdata()
        {
            cmd = new SqlCommand("select book_number as 'Book Number',book_name as 'Book Name',book_id_number as 'Book ID',student_number as 'Student Number',student_name as 'Student Name',now_a_date as 'Giving Date',return_in_days as 'Return Days',return_in_date as 'Return Date' from giving_a_book", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
        }
    }
}
