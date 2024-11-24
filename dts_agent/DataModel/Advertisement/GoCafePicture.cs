using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel.Advertisement
{
    public class GoCafePicture
    {
        [JsonProperty("checksum")]
        public string CheckSum { get; set; }

        [JsonProperty("originalFileName")]
        public string OriginalFileName { get; set; }

        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("gocafePictureType")]
        public string GocafePictureType { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("createdDateTime")]
        public long CreatedDateTime { get; set; }

        [JsonProperty("fileExtension")]
        public string FileExtension { get; set; }

        [JsonProperty("fileKey")]
        public string FileKey { get; set; }

        [JsonProperty("fileSize")]
        public long FileSize { get; set; }

        [JsonProperty("uploadedBy")]
        public string UploadedBy { get; set; }
    }
}