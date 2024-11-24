using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dts_shared.Utilities
{
    public static class ServerConnectionUtility
    {
        public delegate void UpdateUI(bool isOfflineMode);

        private const int SUCCESS_COUNT_FOR_CASHIER_ONLINE_MODE = 2;
        private const int SUCCESS_COUNT_FOR_AGENT_ONLINE_MODE = 2;
        private const int CONNECTION_CHECK_INTERVAL = 60000;

        private static bool _isCashier;
        private static string _url;
        private static string _cloudUrl;

        private static bool _isCheckingConnection;

        private static UpdateUI _updateUiFunction;

        public static bool IsOfflineMode { get; set; }

        public static void Initialize(string url, string cloudUrl, bool isCashier, UpdateUI updateUiFunction)
        {
            _url = url;
            _cloudUrl = cloudUrl;
            _isCashier = isCashier;
            _updateUiFunction = updateUiFunction;
        }

        //public static void CheckServerConnection()
        //{
        //    if (_url == null) return;
        //    IsOfflineMode = true;

        //    if (!_isCheckingConnection)
        //    {
        //        _isCheckingConnection = true;
        //        _updateUiFunction(true);
        //        Task.Run(async () =>
        //        {
        //            var successCount = 0;
        //            while (IsOfflineMode)
        //            {
        //                var cancellationTokenSource = new CancellationTokenSource();
        //                var response =
        //                    await TaskManagerModel<ResponseModel>.Instance.Run(
        //                        HealthCheck(cancellationTokenSource.Token), cancellationTokenSource);

        //                if (response != null && response.HttpStatusCode == (int)HttpStatusCode.OK)
        //                    successCount++;
        //                else
        //                    successCount = 0;

        //                if ((_isCashier && successCount >= SUCCESS_COUNT_FOR_CASHIER_ONLINE_MODE)
        //                    || (!_isCashier && successCount >= SUCCESS_COUNT_FOR_AGENT_ONLINE_MODE))
        //                {
        //                    IsOfflineMode = false;
        //                    _isCheckingConnection = false;
        //                    _updateUiFunction(false);
        //                    break;
        //                }

        //                Thread.Sleep(CONNECTION_CHECK_INTERVAL);
        //            }
        //        });
        //    }
        //}

        //private static async Task<ResponseModel> HealthCheck(CancellationToken cancellationToken)
        //{
        //    return await HttpRequestUtility.HttpGetAsync(_url, cancellationToken, cloudUrl: _cloudUrl);
        //}
    }
}