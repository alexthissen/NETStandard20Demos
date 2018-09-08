using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWebAPI.ClientSdk
{
    public class ServerListResponse
    {
        [JsonProperty(PropertyName = "servers")]
        public GameServerInfo[] Servers { get; set; }
    }
}
