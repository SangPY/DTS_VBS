using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.RouteAddress
{
    public sealed class RouteResource
    {
        public static string GetLogoutResource()
        {
            return ($"/api/cafe/localized/v1/clients/logout/customer-account");
        }

        public static string GetPartnerLogoutResource()
        {
            return ($"/api/cafe/localized/v1/clients/partner/log-out");
        }

        public static string GetLogoutTransferUserResource()
        {
            return ($"/api/cafe/localized/v1/clients/transfer/logout/customer-account");
        }

        public static string GetPartnerLogoutTransferUserResource()
        {
            return ($"/api/cafe/localized/v1/clients/partner/transfer-log-out");
        }

        public static string GetBalanceResource()
        {
            return ($"/api/cafe/localized/v1/clients/get/customer-accounts/balance");
        }

        public static string GetLoginResource()
        {
            return ($"/api/cafe/localized/v5/clients/login/customer-account");
        }

        public static string GetLockedStationSessionInfo()
        {
            return ($"/api/cafe/localized/v1/clients/get-locked-station-session-info");
        }

        public static string GetLockedStationSessionInfoPartner()
        {
            return ($"/api/cafe/localized/v1/clients/partner/get-locked-station-session-info");
        }

        public static string GetPartnerLoginResource()
        {
            return ($"/api/cafe/localized/v1/clients/partner/log-in");
        }

        public static string GetOfflineLoginResource()
        {
            return ($"/api/cafe/localized/v1/clients/login/customer-account/offline");
        }

        public static string GetLoginByTransferDetailResource()
        {
            return ($"/api/cafe/localized/v2/clients/transfer/login/customer-account");
        }

        public static string GetPartnerLoginByTransferDetailResource()
        {
            return ($"/api/cafe/localized/v1/clients/partner/transfer-log-in");
        }

        public static string GetChangePasswordResource()
        {
            return ($"/api/cafe/localized/v2/clients/change-password/customer-account");
        }

        public static string GetUpdateMemberProfileResource()
        {
            return ($"/api/cafe/localized/v1/clients/member/update-profile");
        }

        public static string GetAcceptTNCResource()
        {
            return ($"/api/cafe/localized/v1/clients/accept-tnc/member");
        }

        public static string GetAvailablePromoResourceV3()
        {
            return ($"/api/cafe/localized/v3/clients/get/available-promos");
        }

        public static string GetMemberTypesResource()
        {
            return ($"/api/cafe/localized/v1/clients/get/member-types");
        }

        public static string GetHistoryLogsResource()
        {
            return ($"/api/cafe/localized/v2/clients/get/member-transaction-history");
        }

        public static string GetHistoryInnerDetails()
        {
            return ($"/api/cafe/localized/v1/clients/get/member-transaction-history-details");
        }

        public static string GetAvailableRegisterPromoResource()
        {
            return ($"/api/cafe/localized/v1/clients/register-promo/customer-account");
        }

        public static string GetSetLoginAirtimeResource()
        {
            return ($"/api/cafe/localized/v2/clients/set-login-airtime/customer-account");
        }

        public static string GetRedeemCouponResource()
        {
            return ($"/api/cafe/localized/v1/clients/register-coupon/member");
        }

        #region Store / Food and beverage

        public static string GetFoodInventoryResource()
        {
            return ($"/api/inventory/localized/v1/clients/get/branch-retail-pricings");
        }

        public static string GetProductResource()
        {
            return ($"/api/inventory/localized/v1/clients/get/branch-retail-pricing");
        }

        public static string GetAddSalesOrderResource()
        {
            return $"/api/inventory/localized/v1/clients/add/sales-order";
        }

        #endregion Store / Food and beverage

        public static string GetEcardInventoryResource()
        {
            return ($"/api/inventory/localized/v1/clients/get/codes/count");
        }

        public static string GetEshopProductResource()
        {
            return ($"/api/inventory/localized/v1/clients/get/codes/code-type");
        }

        public static string GetEcardRequestResource()
        {
            return ($"/api/inventory/localized/v1/clients/claim-code/member");
        }

        public static string GetPasswordAuthenticationResource()
        {
            return ($"/api/cafe/localized/v2/clients/authenticate/customer-account");
        }

        public static string GetStationInformationResource()
        {
            return ($"/api/cafe/localized/v2/clients/get/stations/name");
        }

        public static string GetMaliciousSoftwareList()
        {
            return ($"/api/crud/localized/v1/system/malicious-software/list");
        }

        public static string GetStationRates()
        {
            return ($"/api/cafe/localized/v1/clients/get/customer-sessions/rates");
        }

        public static string GetBranchPictures(string branchID)
        {
            return ($"/api/cafe/localized/v1/clients/get/branches/{branchID}/gocafe-pictures");
        }

        public static string GetAdsPictures()
        {
            return ($"/api/ads/localized/v1/clients/get-ads");
        }

        public static string GetOrderHistory(string startDateTime, string endDateTime)
        {
            return ($"/api/inventory/localized/v1/clients/get/sales-order?startDateTime={startDateTime}&endDateTime={endDateTime}");
        }

        public static string GetRegisterStation()
        {
            return ($"/api/cafe/localized/v1/branches/register-station");
        }

        public static string GetTermsAndConditionResource()
        {
            return ($"/api/crud/localized/v1/system/terms-and-conditions");
        }

        public static string GetFaqsResource()
        {
            return ($"/api/crud/localized/v1/system/faq/list");
        }

        public static string GetHealthCheckResource()
        {
            return ($"/api/cafe/v1/health");
        }

        public static string GetAppAnalyticsResource()
        {
            return ($"/api/analytics/localized/v2/app-usage/add-log");
        }

        public static string GetAdAnalyticsResource()
        {
            return ($"/api/analytics/localized/v2/ads-usage/add-log");
        }

        public static string GetChangePartnerPassword()
        {
            return ($"/api/cafe/localized/v1/clients/partner/update-password");
        }

        public static string GetLockStationResource()
        {
            return ($"/api/cafe/localized/v1/clients/lock-station");
        }

        public static string GetUnlockStationResource()
        {
            return ($"/api/cafe/localized/v1/clients/unlock-station");
        }

        public static string GetPartnerRestrictions()
        {
            return ($"/api/cafe/localized/v1/clients/partner/get-restrictions");
        }

        public static string GetGamepassSubscription(string username)
        {
            return $"/api/v1/gamepass/subscription/get-details/{username}";
        }
    }
}