using DiscordRpcDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivas
{
    public partial class Form1 : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Form1()
        {
            InitializeComponent();
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("1033376019572342936", ref this.handlers, true, null);
            this.presence.details = "Playing Vivas";
            this.presence.state = "Reading Vivas Info...";
            this.presence.largeImageKey = "vivasb";
            this.presence.smallImageKey = "vivass";
            DiscordRpc.UpdatePresence(ref this.presence);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VivasMain vivas = new VivasMain();
            vivas.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
