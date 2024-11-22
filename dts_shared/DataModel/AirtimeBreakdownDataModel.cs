using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace dts_shared.DataModel
{
    public class AirtimeBreakdownDataModel
    {
        [JsonProperty("buffetAirtime")] public PromoAirTimeDataModel PromoBuffetAirtime { get; set; }

        [JsonProperty("fullDeDuctionAirtime")] public PromoAirTimeDataModel PromoFullDeductionAirtime { get; set; }

        [JsonProperty("couponAirtime")] public PromoAirTimeDataModel CouponAirtime { get; set; }

        [JsonProperty("regularRateAirTime")] public AirTimeDataModel RegularRateAirtime { get; set; }
    }

    public class AirTimeDataModel
    {
        [JsonProperty("stationType")] public string StationType { get; set; }

        [JsonProperty("inUse")] public bool IsInUse { get; set; }

        [JsonProperty("secondsRemaining")] public long SecondsRemaining { get; set; }
    }

    public class PromoAirTimeDataModel
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("stationTypeList")] public List<string> StationTypeList { get; set; }

        [JsonProperty("inUse")] public bool IsInUse { get; set; }

        [JsonProperty("secondsRemaining")] public long SecondsRemaining { get; set; }
    }

    public class AmountChargedDataModel
    {
        [JsonProperty("amountCharged")] public long Price { get; set; }

        [JsonProperty("accountChargingType")] public string AccountChargingType { get; set; }

        [JsonProperty("promoName")] public string PromoName { get; set; }
    }

    public class BirthDayDataModel
    {
        [JsonProperty("day")] public string Day { get; set; }

        [JsonProperty("month")] public string Month { get; set; }

        [JsonProperty("year")] public string Year { get; set; }
    }

    public class BranchDataModel
    {
        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("locationDetail")] public LocationDetailDataModel LocationDetail { get; set; }
    }

    public class LocationDetailDataModel
    {
        [JsonProperty("cityId")] public string CityID { get; set; }

        [JsonProperty("cityName")] public string CityName { get; set; }

        [JsonProperty("companyId")] public string CompanyID { get; set; }

        [JsonProperty("companyName")] public string CompanyName { get; set; }

        [JsonProperty("countryCode")] public string CountryCode { get; set; }

        [JsonProperty("divisionId")] public string DivisionId { get; set; }

        [JsonProperty("divisionName")] public string DivisionName { get; set; }

        [JsonProperty("regionId")] public string RegionID { get; set; }

        [JsonProperty("regionName")] public string RegionName { get; set; }
    }

    public class StationDataModel
    {
        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("stationType")] public string StationType { get; set; }

        [JsonProperty("remarks")] public string Remarks { get; set; }

        [JsonProperty("staticIpAddress")] public string IpAddress { get; set; }

        [JsonProperty("macAddress")] public string MacAddress { get; set; }
    }

    public class CustomerIdentificationsDataModel
    {
        [JsonProperty("idType")] public string IDType { get; set; }

        [JsonProperty("value")] public string Value { get; set; }
    }
}