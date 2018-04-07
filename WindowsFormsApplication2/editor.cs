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
    public partial class editor : Form
    {
        public Form1 fo = new Form1();
        public editor()
        {
            
            InitializeComponent();
        }

        
        public void button1_Click(object sender, EventArgs e)
        {
           if (ls.Checked)
            {
                fo.labelset(textBox1.Text);
                fo.setOpinions("sd d n a sa");
                fo.insertQuestion(textBox1.Text);
                this.Hide();
                fo.Show();

            }
           else if (tf.Checked) //to do create a new True or false Form
            {



            }


           
           /*
            fo.labelset(textBox1.Text);
            fo.setOpinions("sd d n a sa");
            fo.insertQuestion(textBox1.Text);
            this.Hide();
             fo.Show();
            
        */

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
