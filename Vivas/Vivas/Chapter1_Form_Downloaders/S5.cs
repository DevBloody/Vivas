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
    public partial class S5 : Form
    {
        public S5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1xtAOzOjKZDlWYYduB9prTAzql-2QKB6k&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=12XOammqSvtWrj1Z6LvB5NdIveoDvWSi-&export=download");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1Gyd4Ngmtf4waoqgpfzBhb5Q8tcf9fDAc&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1vFUMklMaWMrlGfsUxD6L6RZ56MHAgi1D&export=download");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1Dd9JmLj-jvOEtVa1OqWfQx4RG75KnLW_&export=download");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1hp2J5zcNnV5dKT5YfV2c74HZlLB7YYTP&export=download");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1fNRu-NOAXBAI49NbxUAeaCNPznyW5JjX&export=download");
        }
    }
}
