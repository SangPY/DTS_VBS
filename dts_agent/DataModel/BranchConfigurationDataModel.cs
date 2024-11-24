using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel
{
    public class BranchConfigurationDataModel
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("settingCode")]
        public string SettingCode { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}