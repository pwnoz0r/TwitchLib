﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitchLib.Model.Static;

namespace TwitchLib.Model
{
    public class GlobalMod
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Admin
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Broadcaster
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Mod
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Staff
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class Turbo
    {

        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("svg")]
        public string Svg { get; set; }
    }

    public class ChatBadges
    {

        [JsonProperty("global_mod")]
        public GlobalMod GlobalMod { get; set; }

        [JsonProperty("admin")]
        public Admin Admin { get; set; }

        [JsonProperty("broadcaster")]
        public Broadcaster Broadcaster { get; set; }

        [JsonProperty("mod")]
        public Mod Mod { get; set; }

        [JsonProperty("staff")]
        public Staff Staff { get; set; }

        [JsonProperty("turbo")]
        public Turbo Turbo { get; set; }

        [JsonProperty("subscriber")]
        public object Subscriber { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }
}
