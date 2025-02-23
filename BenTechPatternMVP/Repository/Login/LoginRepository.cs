using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Repository.Login
{
    class LoginRepository
    {
        private readonly HttpClient _httpClient;

        public LoginRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<HttpResponseMessage> GetUserLoginAsync(string username, string password)
        {
            string apiUrl = "https://localhost:7033/api/login";

            var loginRequest = new
            {
                Username = username,
                Password = password
            };

            var json = JsonConvert.SerializeObject(loginRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);
                return response; 
            }
            catch (Exception ex)
            {
                // Retorna um código 500 (InternalServerError) e a mensagem do erro
                var errorResponse = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent($"Erro na comunicação com a API: {ex.Message}")
                };
                return errorResponse;  // Retorna a resposta com o erro
            }
        }
    }

}
