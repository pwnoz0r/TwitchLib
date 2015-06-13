﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TwitchLib.Model.Static;

namespace TwitchLib.Model
{
    public class Preview
    {

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("medium")]
        public string Medium { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class StreamLive
    {

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("stream")]
        public Static.Stream Stream { get; set; }
    }
}
