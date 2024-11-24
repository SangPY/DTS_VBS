using dts_shared.DataModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel
{
    public class StationInformationDataModel
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string StationID { get; set; }

        [JsonProperty("currency")]
        public CurrencyDataModel Currency { get; set; }

        [JsonProperty("stationType")]
        public string StationType { get; set; }

        [JsonProperty("branch")]
        public StationBranchDataModel Branch { get; set; }

        [JsonProperty("company")]
        public CompanyDataModel Company { get; set; }

        [JsonProperty("configuration")]
        public List<BranchConfigurationDataModel> ConfigurationSettings { get; set; }

        [JsonProperty("locationDetail")]
        public LocationDetailDataModel LocationDetail { get; set; }

        [JsonProperty("softwareVersionNumber")]
        public string SoftwareVersionNumber { get; set; }

        [JsonProperty("appUsageInterval")]
        public int AppUsageInterval { get; set; }

        [JsonProperty("isPartnerAllowed")]
        public bool IsPartnerAllowed { get; set; }

        [JsonProperty("customerType")]
        public string CustomerType { get; set; }

        [JsonProperty("customerSessionId")]
        public string CustomerSessionId { get; set; }

        public bool IsLocked { get; set; }

        [JsonProperty("popupUrl")]
        public string PopupURL { get; set; }

        [JsonProperty("steamPortSetings")]
        public List<PortDataModel> SteamPortSetings { get; set; }
    }
}