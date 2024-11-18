using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_cashier.ViewModelMediator
{
    public class Messages
    {
        public const string GetUserInfo = "GetUserInfo";
        public const string SendUserInfo = "SendUserInfo";
        public const string CashierInfo = "CashierInfo";
        public const string TopUpByUser = "TopUpByUser";
        public const string PCAssigned = "PCAssigned";
        public const string StationList = "StationList";
        public const string TransactionModel = "TransactionModel";

        public const string LogoutUser = "LogoutUser";
        public const string SwitchToLoginView = "SwitchToLoginView";

        public const string CardController = "CardController";
        public const string CardTapped = "CardTapped";
        public const string CardEvent = "CardEvent";
        public const string CardID = "CardID";

        public const string LeftUserControl = "LeftUserControl";
        public const string RightUserControl = "RightUserControl";
        public const string MainViewModel = "MainViewModel";

        public const string CashierViewModel = "CashierViewModel";
        public const string ShowBlurBackground = "ShowBlurBackground";

        public const string AccountManagerViewModel = "AccountManagerViewModel";
        public const string AccountManagerWindow = "AccountManagerWindow";
        public const string AccountManagerOfflineViewModel = "AccountManagerOfflineViewModel";
        public const string AccountManagerWindowOffline = "AccountManagerWindowOffline";

        public const string CashierSyncViewModel = "CashierSyncViewModel";
        public const string CashierSyncWindow = "CashierSyncWindow";

        public const string ConfirmCancelSyncViewModel = "ConfirmCancelSyncViewModel";
        public const string ConfirmCancelSyncWindow = "ConfirmCancelSyncWindow";

        public const string ResetPasswordViewModel = "ResetPasswordViewModel";
        public const string ResetPasswordWindow = "ResetPasswordWindow";

        public const string TopUpManagerViewModel = "TopUpManagerViewModel";
        public const string TopUpManagerWindow = "TopUpManagerWindow";
        public const string TopUpManagerOfflineViewModel = "TopUpManagerOfflineViewModel";
        public const string TopUpManagerOfflineWindow = "TopUpManagerOfflineWindow";

        public const string ConfirmationWindowViewModel = "ConfirmationWindowViewModel";
        public const string ConfirmationWithHighlightWindowViewModel = "ConfirmationWithHighlightWindowViewModel";
        public const string ConfirmationWindow = "ConfirmationWindow";
        public const string WarningConfirmation = "WarningConfirmation";
        public const string WarningOkConfirmation = "WarningOkConfirmation";
        public const string SuccessConfirmation = "SuccessConfirmation";
        public const string ErrorConfirmation = "ErrorConfirmation";
        public const string CancelConfirmation = "CancelConfirmation";
        public const string RemoveConfirmation = "RemoveConfirmation";
        public const string PasswordNotification = "PasswordNotification";
        public const string CloseConfirmationWindow = "CloseConfirmationWindow";
        public const string RetryConfirmationWindow = "RetryConfirmationWindow";
        public const string ConfirmationLabel = "ConfirmationLabel";
        public const string ConfirmationBackgroundColor = "ConfirmationBackgroundColor";

        public const string CouponManagerViewModel = "CouponManagerViewModel";
        public const string CouponManagerWindow = "CouponManagerWindow";
        public const string SelectAllStationType = "SelectAllStationType";
        public const string UnSelectAllStationType = "UnSelectAllStationType";
        public const string SelectAllOnlyTrigger = "SelectAllOnlyTrigger";
        public const string SelectMemberType = "SelectMemberType";

        public const string StoreWindowViewModel = "StoreWindowViewModel";
        public const string StoreWindow = "StoreWindow";
        public const string FilterFoodAndBeverageList = "FilterFoodAndBeverageList";
        public const string SearchFoodAndBeverage = "SearchFoodAndBeverage";
        public const string UpdateOrderCount = "UpdateOrderCount";

        public const string InventoryManagerWindowViewModel = "InventoryManagerWindowViewModel";
        public const string InventoryManagerWindow = "InventoryManagerWindow";
        public const string InventoryManagerModel = "InventoryManagerModel";
        public const string IsModified = "IsModified";

        public const string EShopWindowViewModel = "EShopWindowViewModel";
        public const string EShopWindow = "EShopWindow";

        public const string EmailPopUpWindowViewModel = "EmailPopUpWindowViewModel";
        public const string EmailPopUpWindow = "EmailPopUpWindow";
        public const string EmailAddress = "EmailAddress";

        public const string InventoryPopUpWindowViewModel = "InventoryPopUpWindowViewModel";
        public const string InventoryPopUpWindow = "InventoryPopUpWindow";
        public const string SelectedItem = "SelectedItem";
        public const string ChangeType = "ChangeType";

        public const string EShopPopUpWindowViewModel = "EShopPopUpWindowViewModel";
        public const string EShopPopUpWindow = "EShopPopUpWindow";
        public const string PurchasedItem = "PurchasedItem";
        public const string ItemPayed = "ItemPayed";

        public const string SummaryWindowViewModel = "SummaryWindowViewModel";
        public const string SummaryWindow = "SummaryWindow";
        public const string SummaryTitle = "SummaryTitle";
        public const string SummaryContent = "SummaryContent";
        public const string OtherSummaryContent = "OtherSummaryContent";
        public const string PurchaseOrderSummaryTitle = "Purchase Order Summary";

        public const string UpdateAvailableViewModel = "UpdateAvailableViewModel";
        public const string UpdateAvailableWindow = "UpdateAvailableWindow";
        public const string UpdateAvailableVersion = "UpdateAvailableVersion";
        public const string UpdateAvailableType = "UpdateAvailableType";

        public const string LogOutCustomerWindowViewModel = "LogOutCustomerWindowViewModel";
        public const string LogOutCustomerWindow = "LogOutCustomerWindow";

        public const string TransactionHistoryWindowViewModel = "TransactionHistoryWindowViewModel";
        public const string TransactionHistoryWindow = "TransactionHistoryWindow";

        public const string ReceivedOrdersWindow = "ReceivedOrdersWindow";
        public const string ReceivedOrdersViewModel = "ReceivedOrdersViewModel";
        public const string ReceivedPendingOrdersCount = "ReceivedPendingOrdersCount";
        public const string OpenReceivedOrderWindow = "OpenReceivedOrderWindow";

        public const string PendingOrdersWindow = "PendingOrdersWindow";
        public const string PendingOrdersWindowViewModel = "PendingOrdersWindowViewModel";
        public const string PendingOrdersCount = "PendingOrdersCount";
        public const string OpenClosePendingOrdersWindow = "OpenClosePendingOrdersWindow";

        public const string PasswordConfirmationWindow = "PasswordConfirmationWindow";
        public const string PasswordConfirmationWindowViewModel = "PasswordConfirmationWindowViewModel";
        public const string Username = "Username";

        public const string WindowInitializationError = "WindowInitializationError";

        public const string GenericDialogWindow = "Confirmation Window";

        public const string GuestAccount = "GuestAccount";

        public const string IsProcessing = "IsProcessing";
        public const string ProcessingText = "ProcessingText";

        public const string LoginGuest = "LoginGuest";

        public const string LoginWindows = "LoginWindows";
        public const string StopLoading = "StopLoading";

        public const string PCTransferWindow = "PCTransferWindow";
        public const string PCTransferWindowViewModel = "PCTransferWindowViewModel";
        public const string SelectedWorkstationToTransfer = "SelectedWorkstationToTransfer";

        public const string RefreshAccessToken = "RefreshAccessTokens";
        public const string RefreshAccessKey = "RefreshAccessKeys";

        public const string EndShiftWindow = "EndShiftWindow";
        public const string EndShiftWindowViewModel = "EndShiftWindowViewModel";

        public const string EndShiftSummaryWindow = "EndShiftSummaryWindow";
        public const string EndShiftSummaryWindowViewModel = "EndShiftSummaryWindowViewModel";
        public const string EndShiftData = "EndShiftData";

        public const string PreviousShiftWindow = "PreviousShiftWindow";
        public const string PreviousShiftSummaryWindow = "PreviousShiftSummaryWindow";
        public const string PreviousShiftWindowViewModel = "PreviousShiftWindowViewModel";
        public const string PreviousShiftSummaryWindowViewModel = "PreviousShiftSummaryWindowViewModel";
        public const string PreviousShiftData = "PreviousShiftData";

        public const string CurrentShiftWindow = "CurrentShiftWindow";
        public const string CurrentShiftSummaryWindow = "CurrentShiftSummaryWindow";
        public const string CurrentShiftWindowViewModel = "CurrentShiftWindowViewModel";
        public const string CurrentShiftSummaryWindowViewModel = "CurrentShiftSummaryWindowViewModel";
        public const string CurrentShiftData = "CurrentShiftData";

        public const string VoidConfirmationWindow = "VoidConfirmationWindow";
        public const string VoidConfirmationWindowViewModel = "VoidConfirmationWindowViewModel";

        public const string InformAgentTransaction = "InformAgentTransaction";
        public const string MemberData = "MemberData";

        public const string NetworkStarterModel = "NetworkStarterModel";
        public const string ResetNetComms = "ResetNetComms";

        public const string ConnectionEstablished = "ConnectionEstablished";
        public const string ClientAccountDetails = "ClientAccountDetails";
        public const string ClientDisconnected = "ClientDisconnected";
        public const string ClientUpdatedAccountBalance = "ClientUpdatedAccountBalance";
        public const string ClientOutdatedVersion = "ClientOutdatedVersion";
        public const string ClientMessageReceived = "ClientMessageReceived";
        public const string ClientSuccessfullyReceivedMessage = "ClientSuccessfullyReceivedMessage";
        public const string ClientSuccessfullySeenMessage = "ClientSuccessfullySeenMessage";
        public const string ClientHasLogoutChatEnd = "ClientHasLogoutChatEnd";
        public const string ClientNewLoginChatEnd = "ClientNewLoginChatEnd";
        public const string LockPC = "LockPC";
        public const string ClientOrderDetail = "InformOrderDetail";
        public const string ClientLogout = "ClientLogout";
        public const string ClientTransferToken = "ClientTransferToken";
        public const string CashierNotRegistered = "CashierNotRegistered";
        public const string CashierRegistered = "CashierRegistered";
        public const string ClientTransferStatusDetail = "ClientTransferStatusDetail";
        public const string CashierInvalidAccount = "CashierInvalidAccount";

        public const string ChatWindowViewModel = "ChatWindowViewModel";
        public const string ChatWindow = "ChatWindow";
        public const string ClientChat = "ClientChat";

        public const string OpenTopUpManager = "OpenTopUpManager";
        public const string OpenStore = "OpenStore";
        public const string OpenAccountManager = "OpenAccountManager";
        public const string OpenInventoryManager = "OpenInventoryManager";
        public const string OpenReceivedOrders = "OpenReceivedOrders";
        public const string OpenTransactionHistory = "OpenTransactionHistory";
        public const string OpenCurrentShift = "OpenCurrentShift";
        public const string OpenCoupon = "OpenCoupon";
        public const string OpenResetPassword = "OpenResetPassword";
        public const string OpenLogOutCustomer = "OpenLogOutCustomer";
        public const string OpenStoreItemDetail = "OpenStoreItemDetail";
        public const string OpenStorePurchaseEloadConfirmation = "OpenStorePurchaseEloadConfirmation";

        public const string IsFocusedOnTextbox = "IsFocusedOnTextbox";

        public const string GetUpdatedOrderNumbers = "GetUpdatedOrderNumbers";
        public const string HandledOrder = "HandledOrder";

        public const string OrderRejectReasonWindow = "OrderRejectReasonWindow";
        public const string OrderRejectReasonViewModel = "OrderRejectReasonViewModel";
        public const string OrderRejectReasonMessage = "OrderRejectReasonMessage";

        public const string TopupConfirmationWindow = "TopupConfirmationWindow";
        public const string TopupConfirmationWindowViewModel = "TopupConfirmationWindowViewModel";
        public const string TopupData = "TopupData";

        public const string VoidReasonWindowViewModel = "VoidReasonWindowViewModel";
        public const string VoidReasonWindow = "VoidReasonWindow";
        public const string VoidReason = "VoidReason";
        public const string OpenCustomerSupport = "OpenCustomerSupport";

        public const string PCStatusGuideViewModel = "PCStatusGuideViewModel";
        public const string OpenPCStatusGuide = "OpenPCStatusGuide";
        public const string ClosePCStatusGuide = "ClosePCStatusGuide";

        public const string CustomerSupportClose = "CustomerSupportClose";
        public const string CustomerSupportWindow = "CustomerSupportWindow";
        public const string CustomerSupportWindowViewModel = "CustomerSupportWindowViewModel";

        public const string ChatSupportClose = "ChatSupportClose";
        public const string ChatSupportView = "ChatSupportView";
        public const string ChatSupportViewModel = "ChatSupportViewModel";
        public const string ChatSupportUpdateChatModel = "ChatSupportUpdateChatModel";
        public const string ChatSupportPCList = "ChatSupportPCList";
        public const string ChatSupportPCLoggedOut = "ChatSupportPCLoggedOut";

        public const string SetToOfflineMode = "SetToOfflineMode";
        public const string SetToOnlineMode = "SetToOnlineMode";
        public const string GetOfflineTransactionCount = "GetOfflineTransactionCount";
        public const string SetCashierSyncButtonVisibility = "SetCashierSyncButtonVisibility";

        public const string StoreProductDetailWindowViewModel = nameof(StoreProductDetailWindowViewModel);
        public const string ProductDetails = nameof(ProductDetails);

        public const string StorePurchaseConfirmationWindowViewModel = nameof(StorePurchaseConfirmationWindowViewModel);
        public const string StorePurchaseConfirmationWindow = nameof(StorePurchaseConfirmationWindow);

        public const string StorePurchaseDetailViewModel = nameof(StorePurchaseDetailViewModel);
        public const string StorePurchaseDetailWindow = nameof(StorePurchaseDetailWindow);
        public const string StorePurchaseDetailClose = nameof(StorePurchaseDetailClose);

        public const string UnitActionsWindowViewModel = nameof(UnitActionsWindowViewModel);
        public const string UnitActionsWindow = nameof(UnitActionsWindow);
        public const string SelectedPc = nameof(SelectedPc);

        public const string UpdateSelectedItems = nameof(UpdateSelectedItems);

        public const string LogoutSelectionWindowViewModel = nameof(LogoutSelectionWindowViewModel);
        public const string LogoutSelectionWindow = nameof(LogoutSelectionWindow);

        public const string SignOutWindowViewModel = nameof(SignOutWindowViewModel);
        public const string SignOutWindow = nameof(SignOutWindow);

        public const string OTHER_EXPENSES_VIEWMODEL = nameof(OTHER_EXPENSES_VIEWMODEL);
        public const string OTHER_EXPENSES_OPEN_WINDOW = nameof(OTHER_EXPENSES_OPEN_WINDOW);
        public const string OTHER_EXPENSES_CLOSE_WINDOW = nameof(OTHER_EXPENSES_CLOSE_WINDOW);
        public const string OTHER_EXPENSES_SEND_DETAILS = nameof(OTHER_EXPENSES_SEND_DETAILS);

        public const string REVIEW_EXPENSES_VIEWMODEL = nameof(REVIEW_EXPENSES_VIEWMODEL);
        public const string REVIEW_EXPENSES_OPEN_WINDOW = nameof(REVIEW_EXPENSES_OPEN_WINDOW);
        public const string REVIEW_EXPENSES_CLOSE_WINDOW = nameof(REVIEW_EXPENSES_CLOSE_WINDOW);
        public const string REVIEW_EXPENSES_SHOW_WINDOW = nameof(REVIEW_EXPENSES_SHOW_WINDOW);
        public const string REVIEW_EXPENSES_SEND_OTHER_EXPENSES = nameof(REVIEW_EXPENSES_SEND_OTHER_EXPENSES);
        public const string REVIEW_EXPENSES_SEND_CASHIER_DATA = nameof(REVIEW_EXPENSES_SEND_CASHIER_DATA);

        public const string OTHER_EXPENSES_CREDENTIALS_VIEWMODEL = nameof(OTHER_EXPENSES_CREDENTIALS_VIEWMODEL);
        public const string OTHER_EXPENSES_CREDENTIALS_OPEN_WINDOW = nameof(OTHER_EXPENSES_CREDENTIALS_OPEN_WINDOW);

        public const string REVIEW_EXPENSES_AUTHENTICATION_VIEWMODEL = nameof(REVIEW_EXPENSES_AUTHENTICATION_VIEWMODEL);

        public const string REVIEW_EXPENSES_AUTHENTICATION_OPEN_WINDOW =
            nameof(REVIEW_EXPENSES_AUTHENTICATION_OPEN_WINDOW);

        public const string REVIEW_EXPENSES_AUTHENTICATION_CLOSE_WINDOW =
            nameof(REVIEW_EXPENSES_AUTHENTICATION_CLOSE_WINDOW);

        public const string REVIEW_EXPENSES_AUTHENTICATION_SEND_EXPENSES_IDS =
            nameof(REVIEW_EXPENSES_AUTHENTICATION_SEND_EXPENSES_IDS);

        public const string REVIEW_EXPENSES_AUTHENTICATION_SEND_CASHIER_DATA =
            nameof(REVIEW_EXPENSES_AUTHENTICATION_SEND_CASHIER_DATA);

        public const string LOGOUT_SELECTION_OPEN_REVIEW_OTHER_EXPENSES =
            nameof(LOGOUT_SELECTION_OPEN_REVIEW_OTHER_EXPENSES);

        public const string LOGOUT_SELECTION_OPEN_ENDSHIFT = nameof(LOGOUT_SELECTION_OPEN_ENDSHIFT);

        public const string WarningMaliciousActivityDetected = nameof(WarningMaliciousActivityDetected);

        public const string CASHIER_LOGS = nameof(CASHIER_LOGS);
        public const string TIMER_SUSPENDED = nameof(TIMER_SUSPENDED);
        public const string TOO_MUCH_DELAY = nameof(TOO_MUCH_DELAY);
        public const string TIMER_STOPPED = nameof(TIMER_STOPPED);
        public const string MALICIOUS_ACTIVITY = nameof(MALICIOUS_ACTIVITY);
        public const string EXCEPTION_EVENT = nameof(EXCEPTION_EVENT);

        public const string MALICIOUS_ACTIVITY_WINDOW = nameof(MALICIOUS_ACTIVITY_WINDOW);
        public const string MALICIOUS_ACTIVITY_WINDOW_VIEW_MODEL = nameof(MALICIOUS_ACTIVITY_WINDOW_VIEW_MODEL);
        public const string RELOAD_LOGS = nameof(RELOAD_LOGS);
        public const string MALICIOUS_ACTIVITY_DATA = nameof(MALICIOUS_ACTIVITY_DATA);

        public const string OPEN_QUICK_ADD_GUEST_WINDOW = nameof(OPEN_QUICK_ADD_GUEST_WINDOW);
        public const string QUICK_ADD_GUEST_WINDOW = nameof(QUICK_ADD_GUEST_WINDOW);
        public const string QUICK_ADD_GUEST_WINDOW_VIEW_MODEL = nameof(QUICK_ADD_GUEST_WINDOW_VIEW_MODEL);

        public const string ORDER_TOAST = nameof(ORDER_TOAST);

        public const string OK_RESPONSE = "000";

        public const string SELECTED_PAYMENT_TYPE = nameof(SELECTED_PAYMENT_TYPE);
        public const string APPROVAL_CODE = nameof(APPROVAL_CODE);
        public const string IS_PRINTCHECKED = nameof(IS_PRINTCHECKED);

        public const string SHIFTREPORTVIEWMODEL = nameof(SHIFTREPORTVIEWMODEL);
        public const string SHIFTREPORTWINDOW = nameof(SHIFTREPORTWINDOW);
        public const string SHIFTREPORTCURRENT = nameof(SHIFTREPORTCURRENT);
        public const string SHIFTREPORTPREVIOUS = nameof(SHIFTREPORTPREVIOUS);

        public const string VIEWPCSCREENWINDOW = nameof(VIEWPCSCREENWINDOW);
        public const string VIEWPCSCREENVVIEWMODEL = nameof(VIEWPCSCREENVVIEWMODEL);
        public const string VIEWPCSCREENCURRENTUSER = nameof(VIEWPCSCREENCURRENTUSER);
        public const string PASSWORKSTATION = nameof(PASSWORKSTATION);
        public const string DISPLAYSCREENSHOT = nameof(DISPLAYSCREENSHOT);

        public const string TECHNICAL_SPECS_VIEWMODEL = nameof(TECHNICAL_SPECS_VIEWMODEL);
        public const string TECHNICAL_SPECS_WINDOW = nameof(TECHNICAL_SPECS_WINDOW);
        public const string TECHNICAL_SPECS_IPS = nameof(TECHNICAL_SPECS_IPS);

        public const string USER_TASK_MANAGER_VIEWMODEL = nameof(USER_TASK_MANAGER_VIEWMODEL);
        public const string USER_TASK_MANAGER_VIEW = nameof(USER_TASK_MANAGER_VIEW);
        public const string USER_TASK_MANAGER_PCSELECTED = nameof(USER_TASK_MANAGER_PCSELECTED);
        public const string USER_TASK_MANAGER_PROCESSES = nameof(USER_TASK_MANAGER_PROCESSES);

        public static string MaliciousActivity(string pcName)
        {
            return
                $"Malicius activity detected!!! Please see {pcName} for running app inspection. Some running application on this pc may effect on agent app.";
        }
    }
}