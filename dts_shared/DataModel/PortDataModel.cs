using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_shared.DataModel
{
    public class PortDataModel
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("protocol")] public string Protocol { get; set; }

        [JsonProperty("portNumber")] public int PortNumber { get; set; }
    }
}