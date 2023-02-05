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
    public partial class FortniteChapter1Season1 : Form
    {
        public FortniteChapter1Season1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1A3Y2werWd5mlbp2MlUeP8NL5sEXy8lOn&export=download");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1Me81vbHjPQolFdjhpw_d119qs4OeH8P3&export=download");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1LRDuxDPIOLwW0rXu0tbQL8f1s_sCHm_K&export=download");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1wqzUCr3Ef-SoaBe8cuwvgR6zOi6BucG4&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=18pF3Ws1BoGmenpZqW0r8aqaP1EFHQhiF&export=download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1WZP7o9AEqDIoDYoJqsz-kYu318u8WAD4&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1_N8yv0725BY1C3a3_vfjPPqyorOm6kmK&export=download");
        }
    }
}
