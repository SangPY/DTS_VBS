using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dts_cashier.Cache
{
    public static class DataCacheContext
    {
        //public static Notifier Notifier = new Notifier(cfg =>
        //{
        //    cfg.PositionProvider = new WindowPositionProvider(
        //        Application.Current.MainWindow,
        //        Corner.BottomRight,
        //        20,
        //        50);

        //    cfg.DisplayOptions.Width = 500;

        //    cfg.LifetimeSupervisor = new CountBasedLifetimeSupervisor(
        //        MaximumNotificationCount.FromCount(5));

        //    cfg.Dispatcher = Application.Current.Dispatcher;
        //    cfg.DisplayOptions.TopMost = true;
        //});

        //public static string UserName = string.Empty;
        //public static string Password = string.Empty;
        //public static string CashierSessionID = string.Empty;
        //public static bool UseLocalDB = false;
        //public static string BranchID = string.Empty;
        //public static string BranchName = string.Empty;
        //public static string MacAddress = string.Empty;
        //public static string PrinterName = "POS-58";
        //public static bool PrintReceiptByDefault = true;
        //public static int ServerPort = 54321;
        //public static int AsyncTimeout = 15;
        //public static decimal TopupMaximumAmount = 5000;
        //public static string CurrencySymbol = "đ";
        //public static List<string> StationTypeList;
        //public static string MobileNumberPrefix = "+84";

        //public static string ResourcesDirectory =
        //    Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\..\..\VBS Resources\";

        //public static string Version = "VBS v1.0.0.0";
        //public static bool IsHideShiftStatus = false;
        //public static bool IsShowAddOtherExpense = true;
        //public static bool IsEShopSellingDisabled = false;
        //public static string LanguageSelected = string.Empty;

        //public static SalesRatesDataModel PCStationRates = new SalesRatesDataModel();
        //public static List<PaymentProviderDataModel> PaymentProviders = new List<PaymentProviderDataModel>();
        //public static List<OrderNumberModel> OrderList = new List<OrderNumberModel>();

        //public static Dictionary<string, AccountModel> AccountModels { get; } = new Dictionary<string, AccountModel>();

        //public static ConcurrentDictionary<string, MemberAccountModel> MemberAccountModels { get; } =
        //    new ConcurrentDictionary<string, MemberAccountModel>();

        //public static ConcurrentDictionary<string, ClientPC> WorkstationModels { get; } =
        //    new ConcurrentDictionary<string, ClientPC>();

        //public static ConcurrentBag<NetworkCommsClientModel> NetworkCommsClientModels { get; } =
        //    new ConcurrentBag<NetworkCommsClientModel>();

        //public static string PriceCurrencySymbol =>
        //    VbsMessageResource.CurrentResourceManager.GetString("Price") + CurrencySymbol;
    }
}