using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab08_manhattan.classes
{
    class Geometry
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("coordinates")]
        public List<double> coordinates { get; set; }
    }
}
