using dts_logger.Encryption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dts_logger.Logger
{
    public static class CodedLogger
    {
        private const string codedLogFileName = "\\CodedLogs.txt";
        private const string encryptedLogFileName = "\\Logs.txt";
        private const string policyLogFileName = "\\PolicyLogs.txt";
        private const string clientLogFileName = "\\ClientLogs.txt";
        private const string passphrase = "mxsSatjDygY0bfqF";
        private const string logsLocation = "C:\\VBSLogs";

        public static void LogException(Exception exception)
        {
            try
            {
                if (!Directory.Exists(logsLocation)) Directory.CreateDirectory(logsLocation);

                using (var file = new StreamWriter(logsLocation + encryptedLogFileName, true))
                {
                    file.WriteLine(StringCipher.Encrypt(DateTime.Now + " : Exception: " + exception.GetType()));
                    file.WriteLine(StringCipher.Encrypt(DateTime.Now + " : ExceptionMessage: " + exception.Message));
                    file.WriteLine(StringCipher.Encrypt(DateTime.Now + " : StackTrace: " + exception.StackTrace));
                    if (exception.InnerException != null)
                        file.WriteLine(StringCipher.Encrypt(DateTime.Now + " : InnerException.StackTrace: " +
                                                            exception.InnerException.StackTrace));

                    Debug.WriteLine(DateTime.Now + " : Exception: " + exception.GetType());
                    Debug.WriteLine(DateTime.Now + " : ExceptionMessage: " + exception.Message);
                    Debug.WriteLine(DateTime.Now + " : StackTrace: " + exception.StackTrace);
                    if (exception.InnerException != null)
                        Debug.WriteLine(DateTime.Now + " : InnerException.StackTrace: " +
                                        exception.InnerException.StackTrace);
                }
            }
            catch (Exception e)
            {
            }
        }
    }
}