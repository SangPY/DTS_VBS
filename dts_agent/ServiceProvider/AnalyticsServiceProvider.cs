using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dts_service;
using dts_shared.Model;
using dts_agent.RouteAddress;

namespace dts_agent.ServiceProvider
{
    public class AnalyticsServiceProvider : ServiceProvider, IAnalyticsServiceProvider
    {
        private readonly AnalyticsService analyticsService = new AnalyticsService();

        public async Task<ResponseModel> SendAdAnalytics(int customerAccountId, int ssoId, int stationId, int campaignId, int adId, int clickCount,
           int impressionCount, int viewCount, string countryCode, CancellationToken cancellationToken)
        {
            var response = await analyticsService.SendAdAnalytics(
                ADS_SERVER + RouteResource.GetAdAnalyticsResource(),
                customerAccountId,
                ssoId,
                stationId,
                campaignId,
                adId,
                clickCount,
                impressionCount,
                viewCount,
                countryCode,
                cancellationToken,
                ADS_SERVER + RouteResource.GetAdAnalyticsResource()
            );

            return null;
        }

        public async Task<ResponseModel> SendAppAnalytics(int customerAccountId, int ssoId, int stationId, string appName,
           string title, string fullUrl, string countryCode, CancellationToken cancellationToken)
        {
            var response = await analyticsService.SendAppAnalytics(
                ANALYTICS_SERVER + RouteResource.GetAppAnalyticsResource(),
                customerAccountId,
                ssoId,
                stationId,
                appName,
                title,
                fullUrl,
                countryCode,
                cancellationToken,
                ANALYTICS_SERVER + RouteResource.GetAppAnalyticsResource()
            );

            return null;
        }
    }
}