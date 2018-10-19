using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab08_manhattan.classes
{
    class Feature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Properties Properties { get; set; }
    }
}
