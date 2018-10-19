using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab08_manhattan.classes
{
    class Feature
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }

        [JsonProperty("properties")]
        public Properties properties { get; set; }
    }
}
