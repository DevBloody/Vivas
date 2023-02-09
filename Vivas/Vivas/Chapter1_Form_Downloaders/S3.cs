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
    public partial class S3 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public S3()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.presence.details = "Playing Vivas";
            this.presence.state = "Checking S3 Downloads";
            this.presence.largeImageKey = "vivasb";
            this.presence.smallImageKey = "vivass";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("v3.3 has been removed for the time being");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unable to access/download 3.0 :/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1BU5fgKoEuzI18kIds8kKyvTCfajliB-q&export=download");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=16c1NDzWZc_zb9nQV4ICj1LM9XvBtAGDJ&export=download");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://drive.google.com/u/0/uc?id=1U_4w4Y551Hap9TNS6U9pVpak9oNx4PMt&export=download");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("3.5 is unavailable to download watch the tutorial from discord.gg/erafn for more details");
        }

        private void S3_Load(object sender, EventArgs e)
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
