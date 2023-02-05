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
    public partial class S7 : Form
    {
        public S7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1F8BBwFjbUUpmiM17FZZdXe7FnWu5p4ki&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1ddhWJsKAgSyaQamPOw03LugLC5wcnzbB&export=download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1cnxbLIr8bIGngUKug9KUyH5XoYR-u3Ex&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7.30 can be downloaded using easyinstaller");
        }

        private void S7_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("7.40 can be downloaded using easyinstaller");
        }
    }
}
