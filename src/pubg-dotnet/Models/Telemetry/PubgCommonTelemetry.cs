﻿using Newtonsoft.Json;

namespace Pubg.Net.Models.Telemetry
{
    public class PubgCommonTelemetry
    {
        [JsonProperty]
        public string MatchId { get; set; }

        [JsonProperty]
        public PubgMap MapName { get; set; }

        [JsonProperty]
        public float IsGame { get; set; }
    }
}
