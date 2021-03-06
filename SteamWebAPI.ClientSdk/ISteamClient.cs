﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamWebAPI.ClientSdk
{
    [Headers("User-Agent: Steam WebAPI Client 1.0")]
    public interface ISteamClient
    {
        [Get("/GetServerList/v1")]
        Task<ResponseWrapper> GetServerList(string key, int limit, string format = "json");
    }
}
