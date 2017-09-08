﻿using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using Matrix.Client.Responses;
using Matrix.Client.Types;
using Newtonsoft.Json;

namespace Matrix.Client.Requests
{
    public sealed class LoginRequest : RequestBase<Login>
    {
        public string Address { get; set; }

        public string Medium { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Password { get; set; }

        [Required]
        [JsonProperty(Required = Required.Always)]
        public string Type { get; set; }

        public string User { get; set; }

        public LoginRequest()
            : base("client/{version}/login", HttpMethod.Post, false)
        { }

        public LoginRequest(string user, string password)
            : this()
        {
            User = user;
            Password = password;
            Type = LoginTypes.Password;
        }
    }
}
