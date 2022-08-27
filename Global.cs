using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using Microsoft.CSharp;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.IO;

namespace RestWebinarSample
{
    public class Global
    {
        // REST Serviste tanımlanmış URL bilgisi. (not : "api/v1/" kısmı sabittir.)
        public static string g_URL = "http://10.38.4.21:32001/api/v1/";

        public static string g_UserName = "ANKASTRETEST";   // Tiger girişinde kullanılan kullanıcı adı
        public static string g_UserPass = "Femas2021";
        public static string g_FirmNr = "990";        // Tiger tarafında bağlanılmak istenen firma


        // Aşağıdaki clientID ve clientSecret bilgileri örnek olması amacıyla 01.10.2017 tarihine kadar geçerlidir.
        // Çözüm Ortakları wdev.support@logo.com.tr adresine mail göndererek kendilerine ait ID ve secret bilgilerini öğrenebilirler.
        public static string g_clientID = "PRONIC";
        public static string g_clientSecret = "81NR3YL5HMIuKv3mERS1YKP8NmwwxpYi/0EWH5vXlnw=";

        public static string accessToken = "";
        public static string refreshToken = "";


        public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public static  string getAccessToken(string url, string userName, string password, string firmNr)
        {
           
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(g_clientID + ":" + g_clientSecret)));

                //req.Credentials = CredentialCache.DefaultCredentials;
                //ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateServerCertificate);

                byte[] formData = UTF8Encoding.UTF8.GetBytes("grant_type=password"
                    + "&username=" + userName
                    + "&firmno=" + firmNr
                    + "&password=" + password);

                req.ContentLength = formData.Length;
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }

                dynamic j = JsonConvert.DeserializeObject(result);
                accessToken = j.access_token;
                refreshToken = j.refresh_token;
            }
            catch (Exception Ex)
            {
                accessToken = result;
            }

            return accessToken;
        }

        public static void getRefreshToken(string url)
        {

            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Accept = "application/json";

                byte[] formData = UTF8Encoding.UTF8.GetBytes("grant_type=refresh_token&refresh_token=" + refreshToken);

                req.ContentLength = formData.Length;
                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {

            }

        }

        public static  string HttpPost(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "POST";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {



                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }
            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static string HttpPut(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "PUT";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }


            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static string HttpPatch(string url, string param, string accessToken)
        {
            string result = null;

            try
            {
                HttpWebRequest req = WebRequest.Create(new Uri(url)) as HttpWebRequest;
                req.Method = "PATCH";
                req.ContentType = "application/json";
                req.Accept = "application/json";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                byte[] formData = UTF8Encoding.UTF8.GetBytes(param.ToString());
                req.ContentLength = formData.Length;

                using (Stream post = req.GetRequestStream())
                {
                    post.Write(formData, 0, formData.Length);
                }

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }


            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }
            return result;
        }

        public static  string HttpGet(string url, string accessToken)
        {
            string result = null;
            try
            {
                HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
                req.Method = "GET";
                req.Accept = "application/json, application/octet-stream";
                req.Headers.Add("Authorization", "Bearer  " + accessToken);

                using (HttpWebResponse resp = req.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(resp.GetResponseStream());
                    result = reader.ReadToEnd();
                }

            }
            catch (WebException webEx)
            {
                var response = ((HttpWebResponse)webEx.Response);
                StreamReader content = new StreamReader(response.GetResponseStream());
                result = content.ReadToEnd();
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
            }

            return result;

        }

        public static class Samples
        {
            public static string orderSlip = "{"
                     + "\n  \"INTERNAL_REFERENCE\": 0,"
                     + "\n  \"NUMBER\": \"~\","
                     + "\n  \"DATE\": \"02.05.2016\","
                     + "\n  \"TIME\": 102581337,"
                     + "\n  \"ARP_CODE\": \"CARI.01\","
                     + "\n  \"CURRSEL_TOTAL\": 1,"
                     + "\n  \"TRANSACTIONS\": {"
                     + "\n    \"items\": ["
                     + "\n      {"
                     + "\n        \"TYPE\": 0,"
                     + "\n        \"MASTER_CODE\": \"MALZEME.02\","
                     + "\n        \"QUANTITY\": 5,"
                     + "\n        \"PRICE\": 10,"
                     + "\n        \"VAT_RATE\": 18,"
                     + "\n        \"UNIT_CODE\": \"ADET\","
                     + "\n        \"UNIT_CONV1\": 1,"
                     + "\n        \"UNIT_CONV2\": 1,"
                     + "\n        \"EDT_CURR\": 1"
                     + "\n      }"
                     + "\n    ]"
                     + "\n  }"
                     + "\n }";

            public static string ARPSlip = "{"
                    + "\n   \"INTERNAL_REFERENCE\": 0,"
                    + "\n   \"NUMBER\": \"~\","
                    + "\n   \"DATE\": \"10.10.2016\","
                    + "\n   \"TYPE\": 70,"
                    + "\n   \"CURRSEL_TOTALS\": 1,"
                    + "\n   \"ARP_CODE\": \"CARI.01\","
                    + "\n   \"TIME\": 271789570,"
                    + "\n   \"BANKACC_CODE\": \"BANKA KKHESAP\","
                    + "\n   \"DOC_DATE\": \"10.10.2016\","
                    + "\n   \"SALESMAN_CODE\": \"1\","
                    + "\n   \"CANCEL_AUTO_GL_PROC\": 1,"
                    + "\n   \"TRANSACTIONS\": {"
                    + "\n     \"items\": ["
                    + "\n 	{"
                    + "\n         \"ARP_CODE\": \"CARI.01\","
                    + "\n         \"MODULENR\": 5,"
                    + "\n         \"TRCODE\": 70,"
                    + "\n         \"LINENR\": 1,"
                    + "\n         \"TRANNO\": \"10000052\","
                    + "\n         \"CREDIT\": 1000,"
                    + "\n         \"SIGN\": 1,"
                    + "\n         \"BANKACC_CODE\": \"BANKA KKHESAP\""
                    + "\n     }"
                    + "\n 	]"
                    + "\n   }"
                    + "\n }";


        }
    }


}
