using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.DataModel.Advertisement
{
    public class BranchPicturesDataModel
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("advertisementPictureList")]
        public List<AdvertisementPicturesDataModel> AdvertisementPictureList { get; set; }

        [JsonProperty("lockScreenList")]
        public List<GoCafePicture> LockScreenList { get; set; }

        [JsonProperty("loginScreenList")]
        public List<GoCafePicture> LoginScreenList { get; set; }

        [JsonProperty("pcBackgroundList")]
        public List<GoCafePicture> PcBackgroundList { get; set; }

        [JsonProperty("storePictureList")]
        public List<GoCafePicture> StorePictureList { get; set; }

        [JsonProperty("eshopPictureList")]
        public List<GoCafePicture> EShopPictureList { get; set; }
    }

    public class RandomAdsPicture
    {
        [JsonProperty("infoList")]
        public List<AdsPicture> AdsPictures { get; set; }
    }

    public class AdsPicture
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("pageNo")]
        public int PageNo { get; set; }

        [JsonProperty("createdDate")]
        public long CreatedDateTime { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageURL { get; set; }

        [JsonProperty("hyperLink")]
        public string HyperLink { get; set; }

        [JsonProperty("checksum")]
        public string CheckSum { get; set; }

        [JsonProperty("type")]
        public AdsPictureType AdsPictureType { get; set; }

        [JsonProperty("campaign")]
        public AdsPictureCampaign Campaign { get; set; }

        [JsonProperty("redirectionType")]
        public string RedirectionType { get; set; }
    }

    public class AdsPictureType
    {
        [JsonProperty("adsSection")]
        public string AdsSection { get; set; }

        [JsonProperty("slotNumber")]
        public int SlotNumber { get; set; }

        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
    }

    public class AdsPictureCampaign
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("agency")]
        public AdsPictureCampaignAgency Agency { get; set; }

        [JsonProperty("user")]
        public AdsPictureCampaignUser User { get; set; }
    }

    public class AdsPictureCampaignAgency
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AdsPictureCampaignUser
    {
        [JsonProperty("id")]
        public int ID { get; set; }
    }
}