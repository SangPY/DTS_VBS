using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel.Advertisement
{
    public class AdvertisementPicturesDataModel
    {
        [JsonProperty("createdDateTimeDscp")]
        public string CreatedDateTimeDescription { get; set; }

        [JsonProperty("hyperlink")]
        public string Hyperlink { get; set; }

        [JsonProperty("uploadedByDscp")]
        public string UploadedBy { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("advertisementPicture")]
        public GoCafePicture GocafePicture { get; set; }
    }
}