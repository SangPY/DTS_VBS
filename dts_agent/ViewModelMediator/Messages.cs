using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.ViewModelMediator
{
    public class Messages
    {
        public const string SendUserInfo = "SendUserInfo";
        public const string SendUserPassword = "SendUserPassword";
        public const string UpdatedBalance = "UpdateBalance";
        public const string UpdatedBalanceWithLoad = "UpdatedBalanceWithLoad";
        public const string GetUpdatedBalance = "GetUpdatedBalance";
        public const string AirtimeBreakdown = "AirtimeBreakdown";
        public const string UpdateBonusLoad = "UpdateBonusLoad";
        public const string UpdateLoyaltyPoints = "UpdateLoyaltyPoints";
        public const string UpdateLifetimeLoyaltyPoints = "UpdateLifetimeLoyaltyPoints";
        public const string UpdateBonusLoadAndShowConfirmation = "UpdateBonusLoadAndShowConfirmation";

        public const string LogoutAndRestartUser = "LogoutUser";
        public const string LogoutAndTransferUser = "LogoutAndTransferUser";
        public const string UserInitiatedLogout = "UserInitiatedLogout";
        public const string ResetTimer = "ResetTimer";
        public const string LogoutAndShutdownUser = "LogoutAndShutdownUser";
        public const string RestartUser = "RestartUser";

        public const string MainDashboardUserControl = "MainDashboardUserControl";
        public const string LeftUserControl = "LeftUserControl";

        public const string DashboardUserControl = "DashboardUserControl";
        public const string MyAccountUserControl = "MyAccountUserControl";
        public const string MembershipTierWindow = "MembershipTierWindow";
        public const string FoodAndBeveragesControl = "FoodAndBeveragesControl";
        public const string ProductOrder = "ProductOrder";
        public const string ProductDelete = "ProductDelete";
        public const string PromosControl = "PromosControl";
        public const string AccountBalanceControl = "AccountBalanceControl";
        public const string ResetSelectedPromos = "ResetSelectedPromos";
        public const string PromoPrice = "PromoPrice";
        public const string PromoRechargeLoad = "PromoRechargeLoad";
        public const string PromoAlreadySelected = "PromoAlreadySelected";
        public const string RedeemCouponControl = "RedeemCouponControl";
        public const string StoreControl = "StoreControl";
        public const string UserBalance = "UserBalance";
        public const string LockPin = "LockPin";
        public const string OfflineLocked = "OfflineLocked";
        public const string SetStartTime = "SetStartTime";
        public const string PcStationName = "PcStatioName";
        public const string StationType = "StationType";
        public const string RestartApplication = "RestartApplication";
        public const string HistoryControl = "HistoryControl";
        public const string RatesControl = "RatesControl";
        public const string UpdateActiveRate = "UpdateActiveRate";
        public const string LastErrorStatusEncountered = "LastErrorStatusEncountered";
        public const string IsGenericWindowShown = "IsGenericWindowShown";
        public const string OrderHistoryControl = "OrderHistoryControl";
        public const string ChatboxControl = "ChatboxControl";

        public const string BaseViewModel = "BaseViewModel";

        public const string NetworkStarterModel = "NetworkStarterModel";
        public const string InitializeNetworkStaterModel = "InitializeNetworkStaterModel";

        public const string TermsAndConditionView = "TermsAndConditionView";
        public const string TermsAndConditionWindow = "TermsAndConditionWindow";
        public const string TNCRequestFromLoginWindow = "TNCRequestFromLoginWindow";
        public const string TermsAndCondition = "TermsAndCondition";

        public const string InStorePromoWindow = "InStorePromoWindow";
        public const string InStorePromoViewModel = "InStorePromoViewModel";

        public const string UpdateAvailableViewModel = "UpdateAvailableViewModel";
        public const string UpdateAvailableWindow = "UpdateAvailableWindow";
        public const string UpdateAvailableVersion = "UpdateAvailableVersion";

        public const string FaqsView = "FaqsView";
        public const string FaqsViewModel = "FaqsViewModel";
        public const string Faqs = "Faqs";

        public const string ChatViewModel = "ChatViewModel";
        public const string ChatOpenWindow = "ChatOpenWindow";
        public const string ChatOpenMessages = "ChatOpenMessages";
        public const string ChatOpenPCName = "ChatOpenPCName";
        public const string ChatOpenUserName = "ChatOpenUserName";
        public const string ChatSendMessage = "ChatSendMessage";
        public const string ChatReceivedMessage = "ChatReceivedMessage";
        public const string ChatZeroNotificationMessages = "ChatZeroNotificationMessages";
        public const string ChatReceivedMyMessage = "ChatReceivedMyMessage";
        public const string ChatSeenMessage = "ChatSeenMessage";

        public const string ForgotPasswordViewModel = "ForgotPasswordViewModel";
        public const string ForgotPasswordView = "ForgotPasswordView";
        public const string ForgotPasswordClose = "ForgotPasswordClose";

        public const string ChangePasswordView = "ChangePasswordView";
        public const string ChangePasswordViewModel = "ChangePasswordViewModel";
        public const string ChangePasswordWindow = "ChangePasswordWindow";
        public const string IsChangePasswordFromLogin = "IsChangePasswordFromLogin";

        public const string OpenDashboardControl = "OpenDashboard";
        public const string OpenMyAccountControl = "OpenMyAccount";
        public const string OpenEShopControl = "OpenEShopControl";
        public const string OpenStoreControl = "OpenStoreControl";
        public const string OpenPromosControl = "OpenPromosControl";
        public const string OpenAccountBalanceControl = "OpenAccountBalanceControl";
        public const string OpenCouponControl = "OpenCouponControl";
        public const string OpenHistoryControl = "OpenHistoryControl";
        public const string OpenLockScreenControl = "OpenLockScreenControl";
        public const string OpenRatesControl = "OpenRatesControl";
        public const string OpenOrderHistoryControl = "OpenOrderHistoryControl";
        public const string OpenSignoutControl = "OpenSignoutControl";
        public const string OpenChatboxControl = "OpenChatboxControl";
        public const string SetToOfflineMode = "SetToOfflineMode";
        public const string SetToOnlineMode = "SetToOnlineMode";
        public const string AutoLockScreen = "AutoLockScreen";

        public const string LoginViewModel = "LoginViewModel";
        public const string LoginViewModelGridVisibilityChange = "LoginViewModelGridVisibilityChange";

        public const string LockPopupViewModel = "LockPopupViewModel";
        public const string LockPopupWindow = "LockPopupWindow";
        public const string LockPopupPin = "LockPopupPin";

        public const string LockViewModel = "LockViewModel";
        public const string LockWindow = "LockWindow";

        public const string ConfirmationWindowViewModel = "ConfirmationWindowViewModel";
        public const string ConfirmationWindow = "ConfirmationWindow";
        public const string WarningConfirmation = "WarningConfirmation";
        public const string WarningOkConfirmation = "WarningOkConfirmation";
        public const string SuccessConfirmation = "SuccessConfirmation";
        public const string ErrorConfirmation = "ErrorConfirmation";
        public const string TryAgainConfirmation = "TryAgainConfirmation";
        public const string CancelConfirmation = "CancelConfirmation";
        public const string PasswordNotification = "PasswordNotification";
        public const string CloseConfirmationWindow = "CloseConfirmationWindow";
        public const string RetryConfirmationWindow = "RetryConfirmationWindow";

        public const string SuccessDialogViewModel = "SuccessDialogViewModel";
        public const string SuccessDialogView = "SuccessDialogView";
        public const string SuccessDialogMessage = "SuccessDialogMessage";
        public const string SuccessDialogClose = "SuccessDialogClose";

        public const string ErrorDialogViewModel = "ErrorDialogViewModel";
        public const string ErrorDialogView = "ErrorDialogView";
        public const string ErrorDialogMessage = "ErrorDialogMessage";
        public const string ErrorDialogClose = "ErrorDialogClose";

        public const string ConfirmationDialogViewModel = "ConfirmationDialogViewModel";
        public const string ConfirmationDialogView = "ConfirmationDialogView";
        public const string ConfirmationDialogMessage = "ConfirmationDialogMessage";
        public const string ConfirmationDialogClose = "ConfirmationDialogClose";

        public const string SecurityPolicyView = "SecurityPolicyView";
        public const string SecurityPolicyDialogViewModel = "SecurityPolicyDialogViewModel";

        public const string ConfirmationWithHighlightWindowViewModel = "ConfirmationWithHighlightWindowViewModel";

        public const string ConfirmationPasswordParentWindowViewmodelName = "ConfirmationPasswordParentWindowViewmodelName";
        public const string CloseTransactionConfirmationPasswordWindow = "CloseTransactionConfirmationPasswordWindow";
        public const string ReduceClickAttempts = "ReduceClickAttempts";

        public const string ShowBlurBackground = "ShowBlurBackground";

        public const string ShowStatusOrder = "ShowStatusOrder";
        public const string ShowBonusLoadStatus = "ShowBonusLoadStatus";
        public const string UpdateOrderStatus = "UpdateOrderStatus";
        public const string ShowAirTimeNotification = "ShowAirTimeNotification";

        public const string DashboardWindowHide = "DashboardWindowHide";
        public const string UserInputWrongPassword = "UserInputWrongPassword";

        public const string IsProcessingRequest = "IsProcessingRequest";
        public const string SHOWISPROCESSINGREQUEST = "ShowIsProcessingRequest";

        public const string GenericDialogWindow = "Confirmation Window";

        public const string UpdateOrderHistory = "UpdateOrderHistory";

        public const string RegisterStationToBranch = "RegisterStationToBranch";

        public const string NamedPipeServerRunning = "NamedPipeServerRunning";
        public const string CheckIfOldSessionExists = "CheckIfOldSessionExists";
        public const string OldSessionExists = "OldSessionExists";

        public const string InvalidPassword = "InvalidPassword";

        public const string Relogin = "Relogin";

        public const string IsLoginIdleEnabled = "IsLoginIdleEnabled";
        public const string AsyncTimeout = "AsyncTimeout";
        public const string InsufficientNotificationTimer = "InsufficientNotificationTimer";

        public const string ShowTimer = "ShowTimer";
        public const string DisableAutoMinimize = "DisableAutoMinimize";
        public const string EnableAutoMinimize = "EnableAutoMinimize";
        public const string HideBonusLoadStatus = "HideBonusLoadStatus";

        public const string TNCWindowNull = "TNCWindowNull";
        public const string InsufficientBalance = "InsufficientBalance";
        public const string ShowIncorrectCredentials = "ShowIncorrectCredentials";
        public const string Shutdown = "Shutdown";
        public const string ShutdownApplicationFromCashier = nameof(ShutdownApplicationFromCashier);
        public const string ShutdownUser = "ShutdownUser";
        public const string ShutdownTimer = "ShutdownTimer";
        public const string Logout = "Logout";
        public const string LogoutTransfer = "LogoutTransfer";
        public const string NoActiveCashier = "NoActiveCashier";
        public const string AcceptOrder = "AcceptOrder";
        public const string RejectOrder = "RejectOrder";
        public const string TopupSignal = "TopupSignal";
        public const string TopupPromoSignal = nameof(TopupPromoSignal);
        public const string ServerTransferToken = "ServerTransferToken";
        public const string GuestLogin = "GuestLogin";
        public const string HandshakeAcknowledgement = "HandshakeAcknowledgement";
        public const string ServerChat = "ServerChat";
        public const string OrderQueueNumber = "OrderQueueNumber";
        public const string UpdatedOrderNumbers = "UpdatedOrderNumbers";
        public const string GetUpdatedOrderNumbers = "GetUpdatedOrderNumbers";

        public const string LogOutButtonClicked = "LogOutButtonClicked";
        public const string KeyboardManager = "KeyboardManager";

        public const string SendAccountDetails = "SendAccountDetails";

        public const string VIEWMODEL_STORE_PRODUCT_ITEM_DETAIL = "VIEWMODEL_STORE_PRODUCT_ITEM_DETAIL";
        public const string STORE_PRODUCT_DETAIL_ITEM_DATA = "STORE_PRODUCT_DETAIL_ITEM_DATA";
        public const string STORE_PRODUCT_DETAIL_WINDOW = "STORE_PRODUCT_DETAIL_WINDOW";

        public const string VIEWMODEL_ELOAD_PRODUCT_ITEM_DETAIL = "VIEWMODEL_ELOAD_PRODUCT_ITEM_DETAIL";
        public const string ELOAD_PRODUCT_DETAIL_WINDOW = "ELOAD_PRODUCT_DETAIL_WINDOW";
        public const string ELOAD_PROMO_INSTRUCTION = "ELOAD_PROMO_INSTRUCTION";
        public const string ELOAD_PROMO_CODE = "ELOAD_PROMO_CODE";

        public const string VIEWMODEL_SUCCESSFUL_ELOAD_DIALOG = "VIEWMODEL_SUCCESSFUL_ELOAD_DIALOG";
        public const string SUCCESSFUL_ELOAD_PRODUCT_DETAIL_WINDOW = "SUCCESSFUL_ELOAD_PRODUCT_DETAIL_WINDOW";
        public const string SUCCESSFUL_ELOAD_PROMO_NAME = "SUCCESSFUL_ELOAD_PROMO_NAME";
        public const string SUCCESSFUL_ELOAD_PROMO_INSTRUCTION = "SUCCESSFUL_ELOAD_PROMO_INSTRUCTION";
        public const string SUCCESSFUL_ELOAD_PROMO_CODE = "SUCCESSFUL_ELOAD_PROMO_CODE";

        public const string PurchaseConfirmationViewModel = "PurchaseConfirmationViewModel";
        public const string PurchaseConfirmationWindow = "PurchaseConfirmationWindow";
        public const string AccountBalance = "AccountBalance";
        public const string ItemName = "ItemName";
        public const string ItemPrice = "ItemPrice";
        public const string BalanceAfterPurchase = "BalanceAfterPurchase";
        public const string IsRequestFromLogin = "IsRequestFromLogin";

        public const string PurchasedPromoViewModel = "PurchasedPromoViewModel";
        public const string PurchasedPromoWindow = "PurchasedPromoWindow";
        public const string SetLoginAirtimeFromPromoStore = "SetLoginAirtimeFromPromoStore";

        public const string ConfirmationLabel = "ConfirmationLabel";

        public const string BlockSteamServerCafe = "BlockSteamServerCafe";
        public const string AllowSteamServerCafe = "AllowSteamServerCafe";

        public const string SetTimerAsTopMostFalse = "SetTimerAsTopMostFalse";
        public const string SetTimerAsTopMostTrue = "SetTimerAsTopMostTrue";
        public const string ShoppingBagViewModel = nameof(ShoppingBagViewModel);
        public const string AddCartItem = nameof(AddCartItem);
        public const string UpdateQuantity = nameof(UpdateQuantity);

        public const string ItemDetailsViewModel = nameof(ItemDetailsViewModel);
        public const string ShowDetails = nameof(ShowDetails);
        public const string RecomputeTotal = nameof(RecomputeTotal);
        public const string RefreshCart = nameof(RefreshCart);
        public const string UpdateCartItemCount = nameof(UpdateCartItemCount);
        public const string SendMembershipTier = "SendMembershipTier";
        public const string HideCheckout = nameof(HideCheckout);

        public const string ShoppingBagSubmitOrderViewModel = nameof(ShoppingBagSubmitOrderViewModel);

        public const string LoadTransactionHistory = nameof(LoadTransactionHistory);
        public const string TransactionHistoryWindow = nameof(TransactionHistoryWindow);

        public const string OrderHistoryWindow = nameof(OrderHistoryWindow);
        public const string PurchaseEload = nameof(PurchaseEload);

        public const string ShowAgentWindow = "ShowAgentWindow";

        public const string ApproachDashBoardForMaliciousActivity = "ApproachDashBoardForMaliciousActivity";
        public const string SHUTDOWN_EVENT = nameof(SHUTDOWN_EVENT);
        public const string EXCEPTION_EVENT = nameof(EXCEPTION_EVENT);

        public const string CASHIER_LOGS = nameof(CASHIER_LOGS);
        public const string TIMER_SUSPENDED = nameof(TIMER_SUSPENDED);
        public const string TOO_MUCH_DELAY = nameof(TOO_MUCH_DELAY);
        public const string TIMER_STOPPED = nameof(TIMER_STOPPED);
        public const string MALICIOUS_ACTIVITY = nameof(MALICIOUS_ACTIVITY);

        public const string WINDOW = nameof(WINDOW);
        public const string CLOSE_WINDOW = nameof(CLOSE_WINDOW);

        public const string SEND_AD_IMPRESSIONS = nameof(SEND_AD_IMPRESSIONS);
        public const string DASHBOARD_SELECTION = nameof(DASHBOARD_SELECTION);

        public const string TOPUP_NOTIFICATION_VM = nameof(TOPUP_NOTIFICATION_VM);
        public const string NOTIFIED_TOPUP_VIEW = nameof(NOTIFIED_TOPUP_VIEW);

        public const string TOPUP_PROMO_NOTIFICATION_VM = nameof(TOPUP_PROMO_NOTIFICATION_VM);
        public const string NOTIFIED_TOPUPPROMO_NOTIFICATION_VIEW = nameof(NOTIFIED_TOPUPPROMO_NOTIFICATION_VIEW);

        public const string AGENT_TOPUP_PROMO_NOTIFICATION_VM = nameof(AGENT_TOPUP_PROMO_NOTIFICATION_VM);
        public const string AGENT_NOTIFIED_TOPUPPROMO_NOTIFICATION_VIEW = nameof(AGENT_NOTIFIED_TOPUPPROMO_NOTIFICATION_VIEW);
        public const string AGENT_TOPUP_PROMO_SIGNAL = nameof(AGENT_TOPUP_PROMO_SIGNAL);

        public const string ACCEPTED_ORDER_NOTIFICATION_VM = nameof(ACCEPTED_ORDER_NOTIFICATION_VM);
        public const string NOTIFIED_ACCEPTED_ORDER_VIEW = nameof(NOTIFIED_ACCEPTED_ORDER_VIEW);

        public const string REJECTED_ORDER_NOTIFICATION_VM = nameof(REJECTED_ORDER_NOTIFICATION_VM);
        public const string NOTIFIED_REJECTED_ORDER_VIEW = nameof(NOTIFIED_REJECTED_ORDER_VIEW);

        public const string REDEEMED_COUPON_NOTIFICATION_VM = nameof(REDEEMED_COUPON_NOTIFICATION_VM);
        public const string NOTIFIED_REDEEMED_COUPON_VIEW = nameof(NOTIFIED_REDEEMED_COUPON_VIEW);
        public const string COUPON_REDEEMED_SIGNAL = nameof(COUPON_REDEEMED_SIGNAL);

        public const string PROMOS_NOT_AVAILABLE = nameof(PROMOS_NOT_AVAILABLE);
        public const string SERVERIPADDRESS = nameof(SERVERIPADDRESS);

        public const string HIDESHOPPINGBAG = nameof(HIDESHOPPINGBAG);

        public const string INITIALIZE_LANGUAGES = nameof(INITIALIZE_LANGUAGES);

        public const string ChangeLanguage = "ChangeLanguage";

        public const string RESUME_SHUTDOWN_TIMER = nameof(RESUME_SHUTDOWN_TIMER);

        public const string USER_BAN_UI = nameof(USER_BAN_UI);

        public const string UPDATE_IMAGES = nameof(UPDATE_IMAGES);
        public const string UPDATE_LOGO_IMAGE = nameof(UPDATE_LOGO_IMAGE);
        public const string UPDATE_WALLPAPER_IMAGE = nameof(UPDATE_WALLPAPER_IMAGE);

        public const string RESET_FAILED_REQUEST_COUNT = nameof(RESET_FAILED_REQUEST_COUNT);

        public const string TECHNICAL_SPECS_VIEWMODEL = nameof(TECHNICAL_SPECS_VIEWMODEL);
        public const string TECHNICAL_SPECS_WINDOW = nameof(TECHNICAL_SPECS_WINDOW);
        public const string TECHNICAL_SPECS_LISTOFIPS = nameof(TECHNICAL_SPECS_LISTOFIPS);
    }
}