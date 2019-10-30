using System;
using System.Collections.Generic;
using System.Text;
using SMARTgestion.Models;
using SMARTgestion.Services;
using System.Threading.Tasks;
using System.Net.Http;

namespace SMARTgestion.Data
{
    public class RequerimientosRepository
    {
        private WebService _webService;
        public RequerimientosRepository()
        {
            _webService = new WebService();
        }
        public List<Requerimientos> GetRequerimientos(string requerimientosApiUrl)
        {
            var response = _webService.Get(requerimientosApiUrl);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Requerimientos>>(response.Content);

        }

        public async Task <Response> GetList<T>(string urlBase,
                                                string servicePrefix,
                                                string controller,
                                                string parametros
                                                )
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);
                var url = urlBase.TrimEnd() + servicePrefix.TrimEnd() + controller.TrimEnd() + parametros.TrimEnd();
                var response = await client.GetAsync(url);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = result,
                    };
                }

                var list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(result);
                return new Response
                {
                    IsSuccess = true,
                    Message = "OK",
                    Result = list,
                };
            }
            catch ( Exception ex)
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,
                };
            }
        }
    }
}
