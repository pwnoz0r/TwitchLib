﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TwitchLib.Model
{
    public class Emoticon
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("emoticon_set", NullValueHandling = NullValueHandling.Ignore)]
        public int EmoticonSet { get; set; }
    }

    public class ChatEmoticons
    {

        [JsonProperty("emoticons")]
        public IList<Emoticon> Emoticons { get; set; }
    }
}
