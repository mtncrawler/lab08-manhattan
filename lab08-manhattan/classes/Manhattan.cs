using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace lab08_manhattan.classes
{
    class Manhattan
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("features")]
        public List<Feature> Features { get; set; }
    }
}
