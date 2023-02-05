using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Vivas.Chapter1_Form_Downloaders
{
    public partial class S4 : Form
    {
        public S4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1C4GIAYyUNC9ranP-7yu_47WV3f2W5-A7&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=18sBxOd3xk9HUK6x5cHb4WhLKGTMwD2fz&export=download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=19Np7n2XryciD05M9Hw55fi1fLCI_1zMI&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1SjzeGTf--Q9PASkWV9PqJ-O2zBM_cC--&export=download");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("4.4.1 is unavailable to acess at the moment :/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1G1oRjNY4q5HaMqFSQUeCuHOtRcXvxKnt&export=download");
        }
    }
}
