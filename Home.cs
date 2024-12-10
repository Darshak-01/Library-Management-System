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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_book obj = new add_book();
            obj.Show();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r=MessageBox.Show("Are You Exit In Application","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_book view_obj = new view_book();
            view_obj.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_student add_stud_obj =new add_student();
            add_stud_obj.Show();
        }

        private void viewStudentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stud_detail stud_Detail_obj =new stud_detail();
            stud_Detail_obj.Show();
        }

        private void GivingABookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giving_a_Book giving_A_Book_obj=new Giving_a_Book();    
            giving_A_Book_obj.Show();
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            return_book return_Book_obj=new return_book();
            return_Book_obj.Show();
        }

        private void return_notoolStripMenuItem_Click(object sender, EventArgs e)
        {
            book_not_return book_Not_Return_obj=new book_not_return();
            book_Not_Return_obj.Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
               Environment.Exit(0);
        }
    }
}
