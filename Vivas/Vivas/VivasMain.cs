using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vivas.Chapter1_Form_Downloaders;
namespace Vivas
{
    public partial class VivasMain : Form
    {
        public VivasMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", "/c EasyInstaller.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FortniteChapter1Season1 fn1 = new FortniteChapter1Season1();
            fn1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Season2 s2 = new Season2();
            s2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            S4 s4 = new S4();
            s4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            S3 s3 = new S3();
            s3.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            S5 s5 = new S5();
            s5.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            S6 s6 = new S6();
            s6.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            S7 s7 = new S7();
            s7.ShowDialog();
        }
    }
}
