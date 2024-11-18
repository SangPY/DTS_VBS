using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security;
using System.Text;

using System.Security.Cryptography;

using System.Threading.Tasks;
using dts_logger;
using dts_logger.Logger;

namespace dts_cryptography
{
    public class ConfigDataProtector
    {
        private static byte[] _key;

        public ConfigDataProtector() : this(Process.GetCurrentProcess().MainModule?.FileName)
        {
        }

        public ConfigDataProtector(string filePath)
        {
            CreateSHA512(filePath);
        }

        public void CreateSHA512(string filePath)
        {
            var sha = SHA512.Create();
            try
            {
                using (var stream = File.OpenRead(filePath))
                {
                    _key = sha.ComputeHash(stream);
                }
            }
            catch (PathTooLongException ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine("Path too long!");
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
            catch (DirectoryNotFoundException ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine("Directory not found!");
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
            catch (UnauthorizedAccessException ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine("Unauthorized access!");
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
            catch (FileNotFoundException ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine("File not found!");
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
            catch (IOException ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine("An error occured while opening the file!");
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
            catch (Exception ex)
            {
                CodedLogger.LogException(ex);
#if DEBUG
                Console.WriteLine($"Error: {ex.GetType().Name}\n{ex.StackTrace}");
                throw ex;
#endif
            }
        }

        //public static string EncryptString(string input)
        //{
        //    var encryptedData = ProtectedData.Protect(
        //        Encoding.Unicode.GetBytes(input),
        //        _key,
        //        new DataProtectionScope());
        //    return Convert.ToBase64String(encryptedData);
        //}

        public static string NewEncryptString(string input)
        {
            var paswordBytes = new PasswordDeriveBytes(GetConfigDllSha512(), _key);
            using (var ms = new MemoryStream())
            {
                Aes aesKeyManager = new AesManaged();
                aesKeyManager.Key = paswordBytes.GetBytes(aesKeyManager.KeySize / 8);
                aesKeyManager.IV = paswordBytes.GetBytes(aesKeyManager.BlockSize / 8);
                var cryptoStream = new CryptoStream(ms, aesKeyManager.CreateEncryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(Encoding.UTF8.GetBytes(input), 0, input.Length);
                cryptoStream.Close();
                return Convert.ToBase64String(ms.ToArray());
            }
        }

        public static string GetConfigDllSha512()
        {
            var assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var dllFileName = $"{assemblyFolder}\\{Assembly.GetExecutingAssembly().GetName().Name}.dll";
            var configChecksum = string.Empty;

            var sha = SHA512.Create();
            try
            {
                using (var stream = File.OpenRead(dllFileName))
                {
                    _key = sha.ComputeHash(stream);

                    foreach (var hashKey in _key) configChecksum += hashKey.ToString("x2");

                    return configChecksum;
                }
            }
            catch (Exception ex)
            {
                CodedLogger.LogException(ex);
                return string.Empty;
            }
        }

        public static string NewDecrypt(byte[] input)
        {
            var paswordBytes = new PasswordDeriveBytes(GetConfigDllSha512(), _key);
            using (var ms = new MemoryStream())
            {
                Aes aesKeyManager = new AesManaged();
                aesKeyManager.Key = paswordBytes.GetBytes(aesKeyManager.KeySize / 8);
                aesKeyManager.IV = paswordBytes.GetBytes(aesKeyManager.BlockSize / 8);
                var cryptoStream = new CryptoStream(ms, aesKeyManager.CreateDecryptor(), CryptoStreamMode.Write);
                cryptoStream.Write(input, 0, input.Length);
                cryptoStream.Close();
                return Encoding.UTF8.GetString(ms.ToArray());
            }
        }

        //public static string DecryptString(string encryptedData)
        //{
        //    try
        //    {
        //        var decryptedData = ProtectedData.Unprotect(
        //            Convert.FromBase64String(encryptedData),
        //            _key,
        //            DataProtectionScope.CurrentUser);

        //        return Encoding.Unicode.GetString(decryptedData);
        //    }
        //    catch (Exception ex)
        //    {
        //        CodedLogger.LogException(ex);
        //        return string.Empty;
        //    }
        //}

        public static SecureString ToSecureString(string input)
        {
            var secure = new SecureString();
            foreach (var c in input) secure.AppendChar(c);
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            var returnValue = string.Empty;
            var ptr = Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;
        }
    }
}