using SteamWebAPI.ClientSdk;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamUI
{
    public partial class MainForm : Form
    {
        private const string BaseURL = "https://api.steampowered.com/IGameServersService/";

        public MainForm()
        {
            InitializeComponent();
        }

        private async void buttonGo_Click(object sender, EventArgs e)
        {
            string apiKey = textBoxApiKey.Text;
            if (String.IsNullOrEmpty(apiKey)) return;

            SteamWebApiProxy proxy = new SteamWebApiProxy(BaseURL, apiKey);
            var servers = await proxy.GetServersAsync(10);

            foreach (var server in servers)
            {
                listBoxServers.Items.Add(server);
            }
        }
    }
}
