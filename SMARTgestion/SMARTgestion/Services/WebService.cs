using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SMARTgestion.Models;

namespace SMARTgestion.Services
{
    public class WebService
    {
        public HttpResponse Get(string Url)
        {
            var request = WebRequest.Create(Url);
            request.ContentType = "application/json";
            request.Method = "GET";
                       
            using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
            {
                return BuildResponse(httpResponse);
            }

        }
        private static HttpResponse BuildResponse(HttpWebResponse httpresponse)
        {
            using (StreamReader reader = new StreamReader(httpresponse.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                var response = new HttpResponse();
                response.Content = content;
                response.HttpStatusCode = httpresponse.StatusCode;
                return response;
            }
        }
        public async Task<HttpResponse> GetAsync(string url)
        {
            var request = WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "GET";
            using (HttpWebResponse httpResponse = await request.GetResponseAsync() as HttpWebResponse)
            {
                return BuildResponse(httpResponse);
            }

        }

        public async Task<Response> CheckConnection()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Por favor encienda su configuración de internet",
                };
            }
            var isReachable = await CrossConnectivity.Current.IsRemoteReachable(
                "google.com");
            if (!isReachable)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = "Verifique su conexión de Internet",
                };
            }
            return new Response
            {
                IsSuccess = true,
                Message = "Ok",
            };
        }


    }
}
