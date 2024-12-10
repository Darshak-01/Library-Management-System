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
    public partial class return_book : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public return_book()
        {
            InitializeComponent();
        }

        private void return_book_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();

        }
        private void book_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            String temp=book_id.Text;
            if(e.KeyChar==13)
            {
                if(temp=="")
                {
                    MessageBox.Show("Place Enter The Value In Book ID......!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("select book_number,book_name,student_name from giving_a_book where book_id_number='" +book_id.Text + "'", con);
                    SqlDataReader dr= cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        book_number.Text=dr.GetValue(0).ToString();
                        book_name.Text=dr.GetValue(1).ToString();
                        student_name.Text=dr.GetValue(2).ToString(); 
                        save.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Place Enter Valid Number","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    dr.Close();
                }
            }
        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //int books_number = 1;
            if(book_id.Text=="")
            {
                MessageBox.Show("Place Enter Value In Book Id","Error",MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            else
            {
                cmd = new SqlCommand("select book_number,book_name,student_name from giving_a_book where book_id_number='" + book_id.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    book_number.Text = dr.GetValue(0).ToString();
                    book_name.Text = dr.GetValue(1).ToString();
                    student_name.Text = dr.GetValue(2).ToString();
                    save.Focus();
                }
                dr.Close();
                int temp_id = Convert.ToInt32(book_id.Text);
                cmd = new SqlCommand("select book_id_number from giving_a_book where book_id_number='" + temp_id + "'", con);
                SqlDataReader dr1= cmd.ExecuteReader();
                if (dr1.Read())
                {
                    dr1.Close();
                    int books_number = Convert.ToInt32(book_number.Text);
                    cmd = new SqlCommand("delete from giving_a_book where book_id_number='" + temp_id + "'", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Book return Successfulyy", "Book Return", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        book_id.Clear();
                        book_id.Focus();
                        cmd = new SqlCommand("update add_new_book set book_quntity=book_quntity+1 where book_number='" + books_number + "'", con);
                        cmd.ExecuteNonQuery();
                        book_name.Text = "";
                        book_number.Text = "";
                        student_name.Text = "";
                    }
                }
                else
                {
                    dr1.Close();
                    MessageBox.Show("Place Enter Valid Book ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
