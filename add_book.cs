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
    public partial class add_book : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public add_book()
        {
            InitializeComponent();
        }

        private void add_book_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
            dateTimePicker1.Enabled = false;
        }

        private void Save_book_Click(object sender, EventArgs e)
        {
            if(book_Number.Text=="" || book_name.Text=="" || book_author.Text=="" || book_quntity.Text=="" || book_price.Text=="" )
            {
                MessageBox.Show("Place Enter All Field ","Empty",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("select book_number from add_new_book where book_number='" + Convert.ToInt16(book_Number.Text) + "'", con);
                SqlDataReader dr =cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Place Enter Unique Book Number ", "Unique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    book_Number.Clear();
                    book_Number.Focus();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into add_new_book values('" + Convert.ToInt16(book_Number.Text) + "','" + book_name.Text + "','" + book_author.Text + "','" +Convert.ToInt16(book_quntity.Text) + "','" +Convert.ToInt16(book_price.Text) + "','" + dateTimePicker1.Value.Date + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Value Insert Successfulyy", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        book_Number.Clear();
                        book_name.Clear();
                        book_author.Clear();
                        book_quntity.Clear();
                        book_price.Clear();
                        book_Number.Focus();
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            book_Number.Clear();
            book_name.Clear();
            book_author.Clear();
            book_quntity.Clear();
            book_price.Clear();
        }

        private void book_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                book_name.Focus();
        }

        private void book_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                book_author.Focus();
        }

        private void book_author_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                book_quntity.Focus();
        }

        private void book_quntity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                book_price.Focus();
        }

        private void book_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar==13)
                Save_book.Focus();
        }
    }
}
