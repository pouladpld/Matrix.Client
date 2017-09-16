﻿using Matrix.NET.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Matrix.Client.Responses
{
    public class UploadMediaResponse : IResponse
    {
        [JsonProperty(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
        public string ContentUri { get; set; }
    }
}
