using BenTechPatternMVP.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Repository.Prices
{
    class PriceRepository
    {
        private readonly HttpClient _httpClient;

        public PriceRepository()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(10)
            };

        }

        public async Task<HttpResponseMessage> GetAllPricesAsync()
        {
            string apiUrl = "https://localhost:7033/api/v1/prices";
            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, apiUrl))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    return await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (Exception ex)
            {
                var errorResponse = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent($"Erro na comunicação com a API: {ex.Message}")
                };
                return errorResponse;  // Retorna a resposta com o erro
            }


        }
    }
}
