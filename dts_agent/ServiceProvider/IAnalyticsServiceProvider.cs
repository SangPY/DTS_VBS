using dts_shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dts_agent.ServiceProvider
{
    public interface IAnalyticsServiceProvider
    {
        Task<ResponseModel> SendAppAnalytics(int customerAccountId, int ssoId, int stationId, string appName, string title, string fullUrl, string countryCode, CancellationToken cancellationToken);

        Task<ResponseModel> SendAdAnalytics(int customerAccountId, int ssoId, int stationId, int campaignId, int adId, int clickCount, int impressionCount, int viewCount, string countryCode, CancellationToken cancellationToken);
    }
}