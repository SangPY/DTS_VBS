using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel
{
    public class CurrencyDataModel
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("sign")]
        public string Sign { get; set; }
    }
}