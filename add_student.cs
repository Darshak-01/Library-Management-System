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
    public partial class add_student : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public add_student()
        {
            InitializeComponent();
        }

        private void add_student_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=Pithiya-Bhavesh;Initial Catalog=Library_Management;Integrated Security=True;Encrypt=False");
            con.Open();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            stud_rno.Clear();
            stud_name.Clear();
            stud_spid.Clear();
            stud_stream.SelectedIndex = -1;
            stud_class.SelectedIndex = -1;
            mobile_number.Clear();
            stud_address.Clear();
        }

        private void save_stud_Click(object sender, EventArgs e)
        {
            if(stud_rno.Text=="" || stud_name.Text=="" || stud_spid.Text=="" || stud_stream.SelectedIndex==-1 || stud_class.SelectedIndex==-1 || mobile_number.Text=="" || stud_address.Text=="")
            {
                MessageBox.Show("Place Enter Data in All Field....!","Empty",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                cmd = new SqlCommand("select stud_rno from add_student where stud_rno='" + Convert.ToInt16(stud_rno.Text) + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Place Enter Unique Book Number ", "Unique", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    stud_rno.Clear();
                    stud_rno.Focus();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into add_student values('" + Convert.ToInt16(stud_rno.Text) + "','" + stud_name.Text + "','" + stud_spid.Text + "','" + stud_stream.Text + "','" + stud_class.Text + "','" + mobile_number.Text + "','" + stud_address.Text + "')", con);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Insert Data Successfulyy....!", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        stud_rno.Clear();
                        stud_name.Clear();
                        stud_spid.Clear();
                        stud_stream.SelectedIndex = -1;
                        stud_class.SelectedIndex = -1;
                        mobile_number.Clear();
                        stud_address.Clear();
                        stud_rno.Focus();
                    }
                }
            }
        }

        private void stud_rno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                stud_name.Focus();
        }

        private void stud_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                stud_spid.Focus();
        }

        private void stud_spid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                stud_stream.Focus();
        }

        private void stud_stream_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                stud_class.Focus();
        }

        private void stud_class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                mobile_number.Focus();
        }

        private void mobile_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13) 
                stud_address.Focus();
        }

        private void stud_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                save_stud.Focus();
        }
    }
}
