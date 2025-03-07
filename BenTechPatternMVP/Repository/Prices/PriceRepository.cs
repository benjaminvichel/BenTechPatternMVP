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
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao obter preços.", ex);
            }
        }
        public async Task<HttpResponseMessage> UpdatePriceAsync(HttpContent content)
        {
            string apiUrl = "https://localhost:7033/api/price";
            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, apiUrl))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    requestMessage.Content = content;
                    return await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao atualizar preço.", ex);
            }
        }

        public async Task DeletePriceAsync(string colorCode)
        {
            string apiUrl = $"https://localhost:7033/api/price/{colorCode}";

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Delete, apiUrl))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao excluir preço.", ex);
            }

        }

        public async Task<HttpResponseMessage> CreateNewPriceAsync(HttpContent content)
        {
            string apiUrl = "https://localhost:7033/api/prices";

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiUrl))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    requestMessage.Content = content;
                    return await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (HttpRequestException ex) // Captura erro de rede/API
            {
                throw new Exception("Falha na comunicação com a API ao criar preço.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar requisição para criar preço", ex);
            }
        }

    }
}