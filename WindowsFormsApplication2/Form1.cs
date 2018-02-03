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
    

    public partial class Form1 : Form
    {
        int stronglydisagree = 0;//number of students that stongly disagree
        int disagree = 0;//number of students that disagree
        int neutral = 0;//number of neutral students
        int agree = 0;//number of students that agree
        int stronglyagree = 0;//number of students that strongly agree
        int count = 0;//number of students that contibuted
        private string path = "";

        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)//sd button
        {
            count++;
            stronglydisagree++;
            updateBar();
            if (path == null || path.Equals(""))
            {
                tofile();
            }
            else {
                tofile(path);
            }
            
            //updateBar(count, sd, 1);

        }
        public void setPath(string path) {
            this.path = path;
            
        }
        /*private void updateBar(int tcount, int currcount, int barnum)// this function is responsible for working the algo. for the bars
        {
            int value;
            value = ((currcount * 100) / tcount);
            switch (barnum)
            {
                
                case 1://Strongly disagree
                    sdlabel.Text = value.ToString() + "%";
                    sdbar.Value = value;
                    break;
                case 2:
                    dlabel.Text = value.ToString() + "%";
                    dbar.Value = value;
                    break;
                case 3:
                    nlabel.Text = value.ToString() + "%";
                    nbar.Value = value;
                    break;
                case 4:
                    alabel.Text = value.ToString() + "%";
                    abar.Value = value;
                    break;
                case 5:
                    salabel.Text = value.ToString() + "%";
                    sabar.Value = value;
                    break;



            }




            tlabel.Text = tcount.ToString();

        }
        */
        private void updateBar()
        {
            int sdval = ((stronglydisagree * 100) / count);
            sdlabel.Text = sdval.ToString() + "%";
            sdbar.Value = sdval;

            int dval = ((disagree * 100) / count);
            dlabel.Text = dval.ToString() + "%";
            dbar.Value = dval;

            int nval = ((neutral * 100) / count);
            nlabel.Text = nval.ToString() + "%";
            nbar.Value = nval;

            int aval = ((agree * 100) / count);
            alabel.Text = aval.ToString() + "%";
            abar.Value = aval;

            int saval = ((stronglyagree * 100) / count);
            salabel.Text = saval.ToString() + "%";
            sabar.Value = saval;

            tlabel.Text = count.ToString();

        }
        private void button2_Click(object sender, EventArgs e)//progressBar1.Value = 10;
        {
            count++;
            disagree++;
            updateBar();
            if (path == null || path.Equals(""))
            {
                tofile();
            }
            else
            {
                tofile(path);
            }
            //updateBar(count, d, 2);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.BackColor= Color.FromArgb(255, 102, 178); //change to pink
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void nbutton_Click(object sender, EventArgs e)
        {
            count++;
            neutral++;
            updateBar();
            if (path == null || path.Equals(""))
            {
                tofile();
            }
            else
            {
                tofile(path);
            }
            //updateBar(count, n, 3);
        }

        private void abutton_Click(object sender, EventArgs e)
        {
            count++;
            agree++;
            updateBar();
            if (path == null || path.Equals(""))
            {
                tofile();
            }
            else
            {
                tofile(path);
            }
            //updateBar(count, a, 4);
        }

        private void sabutton_Click(object sender, EventArgs e)
        {
            count++;
            stronglyagree++;
            //updateBar(count, sa, 5);
            updateBar();
            if (path == null || path.Equals(""))
            {
                tofile();
            }
            else
            {
                tofile(path);
            }
        }


        public void tofile(string path= "C:/Users/public/zizi.txt")
        {
            
            string text = label1.Text + "\r\n"+ "\r\n"+ "number of Contributers = " + count + "\r\n" + "\r\n"+
                "number of Students who Strongly Disagree = " + stronglydisagree + "\r\n" + "\r\n"+
                "number of Students who Disagree = "  + disagree + "\r\n" + "\r\n"+
                "number of Students who are Neutral = " +neutral + "\r\n" + "\r\n"+
                "number of Students who Agree = "  + agree + "\r\n" + "\r\n"+
                "number of Students who Strongly Agree = " + stronglyagree ;


            //System.IO.File.WriteAllText(@"C:\Users\Iman\Desktop\WriteText.txt", text);
             
             System.IO.File.WriteAllText(@path, text);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }

        
        public void labelset(string x)
        {
            
            label1.Text = x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            nbutton_Click(sender, e);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            abutton_Click(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sabutton_Click(sender, e);
        }
    }
}
