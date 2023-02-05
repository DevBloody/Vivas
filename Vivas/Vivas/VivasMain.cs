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
    }
}
