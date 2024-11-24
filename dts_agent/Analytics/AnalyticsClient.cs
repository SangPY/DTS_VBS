using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using dts_agent.ServiceProvider;
using dts_agent.Cache;
using dts_agent.DataModel.Advertisement;
using dts_agent.TaskManager;
using dts_shared.Model;

namespace dts_agent.Analytics
{
    public class AnalyticsClient
    {
        #region Fields

        private readonly AnalyticsServiceProvider analyticsServiceProvider = new AnalyticsServiceProvider();

        #endregion Fields

        #region Properties

        public static AnalyticsClient Instance { get; } = new AnalyticsClient();

        #endregion Properties

        public async Task SendAdAnalytics(int adId, int clickCount, int impressionCount, int viewCount)
        {
            int ssoId = DataCacheContext.UserAccountInstance != null ? DataCacheContext.UserAccountInstance.SSOID : 0;
            int customerAccountId = DataCacheContext.UserAccountInstance != null ? DataCacheContext.UserAccountInstance.CustomerAccountId : 0;
            int stationId = 0;
            string countryCode = string.Empty;
            if (DataCacheContext.StationInformationModel != null)
            {
                int.TryParse(DataCacheContext.StationInformationModel.StationID, out stationId);
            }

            if (DataCacheContext.StationInformationModel?.LocationDetail?.CountryCode != null)
            {
                countryCode = DataCacheContext.StationInformationModel.LocationDetail.CountryCode;
            }

            AdsPicture adsDetails = DataCacheContext.AllAdsPictures.AdsPictures.FirstOrDefault(x => x.ID == adId);
            int campaignId = adsDetails?.Campaign != null ? adsDetails.Campaign.ID : 0;

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

            await TaskManagerModel<ResponseModel>.Instance.Run(
                analyticsServiceProvider.SendAdAnalytics(
                    customerAccountId,
                    ssoId,
                    stationId,
                    campaignId,
                    adId,
                    clickCount,
                    impressionCount,
                    viewCount,
                    countryCode,
                    cancellationTokenSource.Token
                ),
                cancellationTokenSource, ToString());
        }
    }
}