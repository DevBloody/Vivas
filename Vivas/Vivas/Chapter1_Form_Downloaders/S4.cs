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
    public partial class S4 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public S4()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.presence.details = "Playing Vivas";
            this.presence.state = "Checking S4 Downloads";
            this.presence.largeImageKey = "vivasb";
            this.presence.smallImageKey = "vivass";
            DiscordRpc.UpdatePresence(ref this.presence);
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

        private void S4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
