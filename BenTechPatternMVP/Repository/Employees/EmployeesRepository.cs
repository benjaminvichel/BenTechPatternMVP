using BenTechPatternMVP.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Repository.Employees
{
    
    class EmployeesRepository
    {
        private readonly HttpClient _httpClient;
        public EmployeesRepository() {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> GetAllEmployeesAsync() {

            string apiUrl = "https://localhost:7033/api/users";

            try {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, apiUrl))
                {
                    requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    return await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (HttpRequestException ex) // Captura erro de rede/API
            {
                throw new Exception("Falha na comunicação com a API ao buscar Users.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar requisição para Users", ex);
            }
        }

        public async Task<HttpResponseMessage> CreateNewEmployeeAsync(HttpContent content) {
            string apiUrl = "https://localhost:7033/api/user/create";

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

        public async Task DeleteEmployeeAsync(Guid id)
        {
            string apiUrl = $"https://localhost:7033/api/users/delete/{id}";

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
                throw new Exception("Falha na comunicação com a API ao excluir Employee.", ex);
            }

        }
        public async Task<HttpResponseMessage> UpdateEmployeeAsync(HttpContent content)
        {
            string apiUrl = "https://localhost:7033/api/user";
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
                throw new Exception("Falha na comunicação com a API ao atualizar employee.", ex);
            }
        }

    }
}
