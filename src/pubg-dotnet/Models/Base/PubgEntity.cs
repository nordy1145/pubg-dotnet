﻿using Newtonsoft.Json;

namespace Pubg.Net
{
    public abstract class PubgEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
