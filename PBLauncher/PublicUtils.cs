using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace PBLauncher
{
    class PublicUtils
    {
        public static string GetPublicIP()
        {
            string url = "http://checkip.dyndns.org";
            System.Net.WebRequest req = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = req.GetResponse();
            System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
            string response = sr.ReadToEnd().Trim();
            string[] a = response.Split(':');
            string a2 = a[1].Substring(1);
            string[] a3 = a2.Split('<');
            string a4 = a3[0];
            return a4;
        }

        public static string GetPublicMAC()
        {
            string mac = null;
            try
            {
                foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
                {
                    try
                    {

                        if (networkInterface.OperationalStatus == OperationalStatus.Up && !networkInterface.Description.Contains("Virtual") && !networkInterface.Description.Contains("Pseudo") && networkInterface.GetPhysicalAddress().ToString() != "")
                        {
                            mac = networkInterface.GetPhysicalAddress().ToString();
                        }
                    }
                    catch (Exception)
                    {
                        mac = "-";
                    }

                }
            }
            catch (Exception)
            {


            }

            return mac;
        }


        public static string ExecutarCMD(string comando)
        {

            using (Process processo = new Process())
            {


                try
                {
                    processo.StartInfo.FileName = Environment.GetEnvironmentVariable("comspec");

                    // Formata a string para passar como argumento para o cmd.exe
                    processo.StartInfo.Arguments = string.Format("/c {0}", comando);

                    processo.StartInfo.RedirectStandardOutput = true;
                    processo.StartInfo.UseShellExecute = false;
                    processo.StartInfo.CreateNoWindow = true;

                    processo.Start();
                    processo.WaitForExit();

                    string saida = processo.StandardOutput.ReadToEnd();


                    return saida;
                }
                catch (Exception)
                {
                    return null;

                }
            }


        }

        public static string GetHash(byte[] bytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(bytes);
                return BitConverter.ToString(hash).ToLower().Replace("-", "");
            }
        }
        public static string GetSalt(string bt)
        {
            string salt = "/x!a@r-$r%an¨.&e&+f*f(f(a)";
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] sBytes = Encoding.UTF8.GetBytes(bt);

            using (var hmac = new HMACMD5(saltBytes))
            {
                byte[] hashBytes = hmac.ComputeHash(sBytes);
                string output = BitConverter.ToString(hashBytes).Replace("-", "");
                return output;
            }
        }



    }
}
