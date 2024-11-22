using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using dts_shared.Enum;

namespace dts_shared.DataModel
{
    public class AccountDataModel : BaseDataModel
    {
        [JsonProperty("customerIdenfications")]
        public List<CustomerIdentificationsDataModel> CustomerIdentifications;

        [JsonProperty("age")] public string Age { get; set; }

        [JsonProperty("airtimeBreakDown")] public AirtimeBreakdownDataModel AirtimeBreakdown { get; set; }

        [JsonProperty("amountChargedObject")] public AmountChargedDataModel AmountCharged { get; set; }

        [JsonProperty("balance")] public string Balance { get; set; }

        [JsonProperty("birthDate")] public string BirthDate { get; set; }

        [JsonProperty("birthDay")] public BirthDayDataModel BirthDay { get; set; }

        [JsonProperty("bonusLoad")] public string BonusLoad { get; set; }

        [JsonProperty("branch")] public BranchDataModel CurrentBranch { get; set; }

        [JsonProperty("branchRegistered")] public BranchDataModel BranchRegistered { get; set; }

        [JsonProperty("currentLoyaltyPoints")] public long CurrentLoyaltyPoint { get; set; }

        [JsonProperty("currentRate")] public string CurrentRate { get; set; }

        [JsonProperty("customerAccountId")] public int CustomerAccountId { get; set; }

        [JsonProperty("customerSessionId")] public string CustomerSessionId { get; set; }

        [JsonProperty("customerType")] public string CustomerType { get; set; }

        [JsonProperty("email")] public string Email { get; set; }

        [JsonProperty("gender")] public GenderEnum Gender { get; set; }

        [JsonProperty("hasAcceptedTnc")] public bool HasAcceptedTnc { get; set; }

        [JsonProperty("hasChangedTemporaryPassword")]
        public bool HasChangedTemporaryPassword { get; set; }

        [JsonProperty("id")] public string ID { get; set; }

        [JsonProperty("lifetimeLoyaltyPoints")]
        public long LifetimeLoyaltyPoints { get; set; }

        [JsonProperty("locationDetail")] public LocationDetailDataModel LocationDetail { get; set; }

        [JsonProperty("membershipDate")] public string MembershipDate { get; set; }

        [JsonProperty("memberType")] public string MemberType { get; set; }

        [JsonProperty("memberTypeDescription")]
        public string MemberTypeDescription { get; set; }

        [JsonProperty("memberTypeId")] public string MemberTypeID { get; set; }

        [JsonProperty("secondsRemaining")] public int SecondsRemaining { get; set; }

        [JsonProperty("showPromo")] public bool ShowPromo { get; set; }

        [JsonProperty("ssoId")] public int SSOID { get; set; }

        [JsonProperty("station")] public StationDataModel Station { get; set; }

        [JsonProperty("username")] public string UserName { get; set; }

        [JsonProperty("mobileNumber")] public string MobileNumber { get; set; }

        [JsonProperty("firstName")] public string FirstName { get; set; }

        [JsonProperty("lastName")] public string LastName { get; set; }

        [JsonProperty("startTime")] public DateTime StartTime { get; set; }

        [JsonProperty("cardNumber")] public string CardNumber { get; set; }

        [JsonProperty("promoName")] public string PromoName { get; set; }

        [JsonProperty("isOfflineGuest")] public bool IsOfflineGuest { get; set; }

        public bool IsLocked { get; set; }

        [JsonProperty("isPartnerLogin")] public bool IsPartnerLogin { get; set; }
    }
}