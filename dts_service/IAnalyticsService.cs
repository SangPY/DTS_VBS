using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using dts_shared.Model;

namespace dts_service
{
    public interface IAnalyticsService
    {
        Task<ResponseModel> SendAppAnalytics(string url, int customerAccountId, int ssoId, int stationId,
            string appName, string title, string fullUrl, string countryCode, CancellationToken cancellationToken,
            string cloudUrl);

        Task<ResponseModel> SendAdAnalytics(string url, int customerAccountId, int ssoId, int stationId, int campaignId,
            int adId, int clickCount, int impressionCount, int viewCount, string countryCode,
            CancellationToken cancellationToken, string cloudUrl);
    }
}