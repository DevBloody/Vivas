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

namespace Vivas.Chapter1_Form_Downloaders
{
    public partial class Season2 : Form
    {
        public Season2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1xWfCgKDzzKHl5xdHHU7y-xqMY8PbcHY3&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1dVS_LVJIepNMMcs5WmSNSQvNWHdlIsmZ&export=download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1gkluSEyrZ9cQKPJQgbHHNXT46VU0kE5v&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2.3.0 Has No Available Downloads");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1JYJ74HbS5GbXyWem4kxNkZm9klOPlvCe&export=download");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=10DjWthGEZR4EWlPeuFie4g9_cc_N1DkA&export=download");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Download 2.5 With EasyInstaller");
        }
    }
}
