using SteamWebAPI.ClientSdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamCLI
{
    class Program
    {
        private const string BaseURL = "https://api.steampowered.com/IGameServersService/";

        static async Task Main(string[] args)
        {
            SteamWebApiProxy proxy = new SteamWebApiProxy(BaseURL, "463522C8ECB65DADD51FE48392114E3A");
            int limit = 10;
            if (args.Length > 0)
            {
                Int32.TryParse(args[0], out limit);
            }
            
            var servers = await proxy.GetServersAsync(limit);
            servers.ForEach(s => Console.WriteLine(s));

            Console.ReadLine();
        }
    }
}
