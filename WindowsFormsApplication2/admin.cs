using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "swall" && txtpass.Text=="swall" && checkBox1.Checked)
            {
                
                this.Hide();
                new editor().Show();
                

            }
            else if(!checkBox1.Checked)
            {
                MessageBox.Show("please agree to the terms and conditions");
               
            }else
            {
                MessageBox.Show("Username or password is incorrect");
               
            }

        }
    }
}
