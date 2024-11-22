using dts_logger.Encryption;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

        public static void LogClearText(string message)
        {
            short num;
            try
            {
                num = 0;
                int num2 = num;
                StreamWriter streamWriter = default(StreamWriter);
                while (true)
                {
                    switch (num2)
                    {
                        case 0:
                            switch (0)
                            {
                                default:
                                    continue;
                                case 0:
                                    break;
                            }

                            goto default;
                        default:
                            while (!Directory.Exists("C:\\VBSLogs"))
                            {
                                num = -19877;
                                short num3 = num;
                                num = -19877;
                                switch (num3 == num)
                                {
                                    case false:
                                    case true:
                                        continue;
                                }

                                goto IL_007e;
                            }

                            goto case 3;
                        case 2:
                            try
                            {
                                streamWriter.WriteLine(StringCipher.Encrypt(DateTime.Now.ToString(CultureInfo.InvariantCulture) + " : " + message));
                            }
                            finally
                            {
                                num = 0;
                                num2 = num;
                                while (true)
                                {
                                    switch (num2)
                                    {
                                        case 0:
                                            switch (0)
                                            {
                                                default:
                                                    continue;
                                                case 0:
                                                    break;
                                            }

                                            goto default;
                                        default:
                                            if (streamWriter != null)
                                            {
                                                num = 1;
                                                num2 = num;
                                                continue;
                                            }

                                            break;

                                        case 1:
                                            ((IDisposable)streamWriter).Dispose();
                                            num = 2;
                                            num2 = num;
                                            continue;
                                        case 2:
                                            break;
                                    }

                                    break;
                                }
                            }

                            num = 4;
                            num2 = num;
                            continue;
                        case 3:
                            streamWriter = new StreamWriter("C:\\VBSLogs\\Logs.txt", append: true);
                            num = 2;
                            num2 = num;
                            continue;
                        case 1:
                            Directory.CreateDirectory("C:\\VBSLogs");
                            num = 3;
                            num2 = num;
                            continue;
                        case 4:
                            break;
                        IL_007e:
                            num = 0;
                            if (num != 0)
                            {
                            }

                            num = 1;
                            num2 = num;
                            continue;
                    }

                    break;
                }
            }
            catch (Exception)
            {
            }

            num = 1;
            if (num != 0)
            {
            }

            num = 0;
            _ = num;
        }
    }
}