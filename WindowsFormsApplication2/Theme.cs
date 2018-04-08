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
    public partial class Theme : Form
    {
        Form1 fo ;
        public Theme(Form1 fo)
        {
            this.fo = fo;
            fo.Activate();
            InitializeComponent();
        }

        public void showhide()
        {
            this.Hide();
            fo.Show();
        }

        private void greenbutt_Click(object sender, EventArgs e)
        {
            fo.ThemeSelect(1);
            showhide();
        }

        private void bluebutt_Click(object sender, EventArgs e)
        {
            fo.ThemeSelect(2);
            showhide();
        }

        private void pinkbutt_Click(object sender, EventArgs e)
        {
            fo.ThemeSelect(3);
            showhide();
        }

        private void redbutt_Click(object sender, EventArgs e)
        {
            fo.ThemeSelect(4);
            showhide();
        }
    }
}
