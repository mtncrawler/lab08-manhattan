using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab08_manhattan.classes
{
    class Manhattan
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("features")]
        public List<Feature> features { get; set; }
    }
}
