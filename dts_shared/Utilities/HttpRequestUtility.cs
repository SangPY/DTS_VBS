using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_shared.Utilities
{
    public class HttpRequestUtility
    {
        public delegate void SuccessfulRequestDelegate();

        public const string Put = "PUT";
        public const string Post = "POST";

        private const int TIMEOUT_IN_MILLIS = 5000;
        private const int TRIGGER_OFFLINE_MODE_COUNT = 2;

        private static int FailedRequests;

        private static string localServer;

        private static SuccessfulRequestDelegate _successfulRequestFunction;

        public static void SetLocalServer(string server)
        {
            localServer = server;
        }

        public static void SetSuccessfulRequestFunction(SuccessfulRequestDelegate successfulRequestFunction)
        {
            _successfulRequestFunction = successfulRequestFunction;
        }
    }
}