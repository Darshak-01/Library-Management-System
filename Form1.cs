using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_project
{
    public partial class Login_From : Form
    {
        public Login_From()
        {
            InitializeComponent();
        }

        private void Login_From_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtuname.Text=="1234" && txtpassword.Text=="1234")
            {
                MessageBox.Show("Your Login is Successfuly ","Login",MessageBoxButtons.OK,MessageBoxIcon.Information);
                
                Home obj=new Home();
                obj.Show();
                this.Hide();
                //  Application.Exit();
               // this.Close();
            }
            else
            {
                MessageBox.Show("Place Enter Valid UserName & PassWord","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtpassword.Clear();
                txtuname.Clear();
                txtuname.Focus();
            }
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPass.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {
            if (txtuname.Text == "" || txtpassword.Text == "")
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if (txtuname.Text == "" || txtpassword.Text == "")
            {
                btnLogin.Enabled = false;
            }
            else
            {
                btnLogin.Enabled = true;
            }
        }
    }
}
