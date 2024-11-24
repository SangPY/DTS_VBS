using dts_shared.DataModel;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dts_agent.DataModel;
using dts_agent.DataModel.Advertisement;

namespace dts_agent.Cache
{
    public class DataCacheContext
    {
        /// <summary>
        /// Gets or sets the user's login state.
        /// </summary>
        public static bool IsUserLoggedIn { get; set; }

        public static string CurrencySign = "₫";

        public static ConcurrentBag<int> ActivatedAds = new ConcurrentBag<int>();

        public static ConcurrentDictionary<int, int> AdsImpressionCounts = new ConcurrentDictionary<int, int>();
        public static ConcurrentDictionary<int, int> AdsViewCounts = new ConcurrentDictionary<int, int>();

        public static AccountDataModel UserAccountInstance { get; set; }

        public static StationInformationDataModel StationInformationModel { get; set; }

        public static RandomAdsPicture AllAdsPictures { get; set; }

        public static int AsyncTimeout = 15;

        public static bool IsUnexpectedErrorWindowOpen = false;

        public static int GenericDialogWindowCount = 0;
    }
}