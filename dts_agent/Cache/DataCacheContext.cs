using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}