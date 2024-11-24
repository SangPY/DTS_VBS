using dts_agent.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_agent.Util
{
    public class AdsUtil
    {
        public static void ClearAllCounts()
        {
            List<int> adsImpressionCountKeys = new List<int>(DataCacheContext.AdsImpressionCounts.Keys);
            List<int> adsViewCountKeys = new List<int>(DataCacheContext.AdsViewCounts.Keys);

            foreach (var key in adsImpressionCountKeys)
            {
                DataCacheContext.AdsImpressionCounts[key] = 0;
            }

            foreach (var key in adsViewCountKeys)
            {
                DataCacheContext.AdsViewCounts[key] = 0;
            }
        }
    }
}