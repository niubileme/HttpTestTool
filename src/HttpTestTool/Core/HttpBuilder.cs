using HttpTestTool.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HttpTestTool.Core
{
    public class HttpBuilder
    {
        static HttpBuilder()
        {
            ServicePointManager.ServerCertificateValidationCallback = CheckValidationResult;
        }

        public static ResponseModel Handle(RequestModel requestModel)
        {
            var respnseModel = new ResponseModel();
            var encoding = Encoding.UTF8;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(requestModel.Url);
                request.Method = requestModel.Method;
                request.Timeout = requestModel.TimeOut;
                request.AllowAutoRedirect = requestModel.AutoRedirect;
                request.KeepAlive = requestModel.KeepAlive;
                foreach (var header in requestModel.Headers)
                {
                    if (header.Key.ToLower() == "content-type")
                        request.ContentType = header.Value;
                    else
                        request.Headers.Add(header.Key, header.Value);
                }

                if (requestModel.Method.ToUpper() == "POST" && !string.IsNullOrWhiteSpace(requestModel.Datas))
                {
                    byte[] datas = Encoding.UTF8.GetBytes(requestModel.Datas);
                    request.ContentLength = datas.Length;
                    using (var requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(datas, 0, datas.Length);
                    }
                }

                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    respnseModel.StatusCode = (int)response.StatusCode;
                    respnseModel.Response = GetResponseBody(response, encoding);
                }
            }
            catch (WebException ex)
            {
                var response = (HttpWebResponse)ex.Response;
                respnseModel.StatusCode = (int)response.StatusCode;
                respnseModel.Response = GetResponseBody(response, encoding);
            }
            catch (Exception ex)
            {
                respnseModel.StatusCode = -1;
                respnseModel.Response = ex.Message;
            }
            return respnseModel;
        }

        private static string GetResponseBody(HttpWebResponse response, Encoding encoding)
        {
            string responseBody = string.Empty;
            if (response.ContentEncoding != null && response.ContentEncoding.ToLower().Contains("gzip"))
            {
                using (GZipStream stream = new GZipStream(response.GetResponseStream(), CompressionMode.Decompress))
                {
                    using (StreamReader reader = new StreamReader(stream, encoding))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            else if (response.ContentEncoding != null && response.ContentEncoding.ToLower().Contains("deflate"))
            {
                using (DeflateStream stream = new DeflateStream(
                    response.GetResponseStream(), CompressionMode.Decompress))
                {
                    using (StreamReader reader =
                        new StreamReader(stream, encoding))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            else
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream, encoding))
                    {
                        responseBody = reader.ReadToEnd();
                    }
                }
            }
            return responseBody;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true; //总是接受  
        }
    }
}
