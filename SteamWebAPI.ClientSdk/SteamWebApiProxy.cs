using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
#if NETSTANDARD2_0
using System.Data;
#endif

namespace SteamWebAPI.ClientSdk
{
    public class SteamWebApiProxy
    {
        private readonly string hostUri;
        private readonly string apiKey;

        public SteamWebApiProxy(string hostUri, string apiKey)
        {
            this.hostUri = hostUri;
            this.apiKey = apiKey;
        }
        public async Task<List<string>> GetServersAsync(int limit)
        {
            var api = RestService.For<ISteamClient>(hostUri);
            try
            {
                return (await api.GetServerList(apiKey, limit))
                    .Response.Servers
                    .Select(s => s.Name).ToList();
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
                return new List<string>() { ex.Message };
            }
        }

#if NETSTANDARD2_0
        public void Retrieve()
        {
            DataSet data = new DataSet();
        }
#endif
    }
}
