using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{


    public partial class Form1 : Form
    {

        
        int count = 0;//number of students that contibuted
        string question = "";
        SQLhandler handler;
        observer ob;
        Boolean firstTime;
        
        Dictionary<string, int> myOpinions; //dictionary to store voters oppinions 
        Dictionary<string, Label> labels;//dictionary to store the labels for the progress bar(to show the percentage)
        Dictionary<string, ProgressBar> bars;//dictionary used to keep track of the values of the progress bar(min zero, max 100 )
        public Form1()
        {
            myOpinions = new Dictionary<string, int>();
            ob = new observer();        
            handler = new SQLhandler();
            labels = new Dictionary<string, Label>();
            bars = new Dictionary<string, ProgressBar>();
            
            firstTime = true;
            InitializeComponent(); //GUI initialization

            bars["sd"] = this.sdbar;
            bars["d"] = this.dbar;
            bars["n"] = this.nbar;
            bars["a"] = this.abar;
            bars["sa"] = this.sabar;
            labels["sd"] = this.sdlabel;
            labels["d"] = this.dlabel;
            labels["n"] = this.nlabel;
            labels["a"] = this.alabel;
            labels["sa"] = this.salabel;
            setOpinions("sd d n a sa");

            question = handler.getLastQuestion();
            labelset(question);
            timer1.Start();

        }

        public void setOpinions(string opinions) //initializer the opinions to zero
        {
            string[] arr = opinions.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {

                myOpinions[arr[i]] = 0;

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            PictureBox clicked = (PictureBox)sender;
            Console.WriteLine(clicked.Name);
           
            myOpinions[clicked.Name] = myOpinions[clicked.Name] + 1;//increment the clicked choice 
            handler.updateOpinion(question, clicked.Name, myOpinions[clicked.Name]);
            count++;
            updateBar();        

        }
        public void insertQuestion(string a) { // inserts a new question into the table 
            question = a;
            handler.addQuestion(a);
        }

        private void updateBar()
        {
            int count = 0;
            foreach (KeyValuePair<string, int> entry in myOpinions)
            {
                count += myOpinions[entry.Key];

            }

            //int i = 0;
            foreach (KeyValuePair<string, int> entry in myOpinions)
            {
                if (count == 0) {
                    count = 1;
                    }

                int percent = myOpinions[entry.Key] * 100 / count;
                labels[entry.Key].Text = percent.ToString() + "%";
                bars[entry.Key].Value = percent;

            }
            tlabel.Text = count.ToString();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (firstTime==true)
            {

                this.BackColor = Color.FromArgb(255, 102, 178); //change to pink
                firstTime = false;
            }
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

         private void button1_Click_2(object sender, EventArgs e)
        {
            new admin().Show(); // shows the admin window 
            this.Hide();// hides this form (Form1)
        }

        public string getquestion()
        {
            return label1.Text;
        }
        public void labelset(string x)
        {

            label1.Text = x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a surveying program that collects the opinions of users by allowing them to vote to a question that is added by an admin. \r\n\r\nAdd/Delete questions:\r\nUsername and Password needed to change the question or edit the layout. ","About");
        }

        public void realTimeUpdater()
        {

            int[] arr=ob.dbpoll(question);
            int i = 0;
            List<string> keys = new List<string>(myOpinions.Keys);
            foreach (string key in keys)
            {


                myOpinions[key] = arr[i];
                i++;
            }

                updateBar();
            }

        private void timer1_Tick(object sender, EventArgs e)
        {
            realTimeUpdater();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Theme(this).Show();
        }
        public void ThemeSelect(int x)
        {
            
            int caseSwitch = x;

            switch (caseSwitch)
            {
                case 1:
                    this.BackColor = Color.FromArgb(244, 32, 32); //change to red
                    break;
                case 2:
                    this.BackColor = Color.FromArgb(0, 204, 204); //change to blue
                    break;
                case 3:
                    this.BackColor = Color.FromArgb(255, 102, 178); //change to pink
                    break;
                case 4:
                    this.BackColor= Color.FromArgb(1, 182, 15); //change to green
                    break;
                default:
                    this.BackColor = Color.FromArgb(255, 102, 178); //change to pink
                    break;
            }
        }
    }
}


