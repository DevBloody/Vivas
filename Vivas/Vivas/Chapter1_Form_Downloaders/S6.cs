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
using DiscordRpcDemo;

namespace Vivas.Chapter1_Form_Downloaders
{
    public partial class S6 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public S6()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.presence.details = "Playing Vivas";
            this.presence.state = "Checking S6 Downloads";
            this.presence.largeImageKey = "vivasb";
            this.presence.smallImageKey = "vivass";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1K9qb2je0CD6bIaqDxqtlJUvEgWl-sNX6&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unavailable to access 6.00-CL-4402180 :/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1klzACR9ocUelRdSVVl9ef3lLz2VCaWeM&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1u-bij6Gq9_wEVM1G04TP7JI2txNrakQb&export=download");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1vc5a6OSKehILsckZUYEaRcd-a1Ch1Y-T&export=download");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1SlWF87kNH1PKwu-cRWyuktrS2vVt-pHz&export=download");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1H-R_WaVZtVRYsox3PKbXlGEwpTGtJdtE&export=download");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1mDJ66GhmFMQioVU5j39e_W-1E6bZMT7s&export=download");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EFortToastType 6.10 Build Is Unavailable :/ \n \n \n or is it");
            Process.Start("https://drive.google.com/u/0/uc?id=1z0S3S8Khz8hY8qL7UbL9FYti5u6qVxsr&export=download");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unavaialbe to access 6.20 :/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1RYBJSsPFWJO2AW4HhSn6MausgqmcFCGI&export=download");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1HrE2Wx6JJ_cOUgqVIQFqFQH7ZdSxEqAw&export=download");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1MTVkUXi7tD4WETlTIMuUrF6ioYeAxI_a&export=download");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1lu-Rruktpk8OpfmFRv7Q63lDPffmsQip&export=download");
        }

        private void S6_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            VivasMain m = new VivasMain();
            m.ShowDialog();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.presence.details = "Playing Vivas";
            this.presence.state = "In Main";
            this.presence.largeImageKey = "vivasb";
            this.presence.smallImageKey = "vivass";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
