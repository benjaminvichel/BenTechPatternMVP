﻿using BenTechPatternMVP.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Repository.Dates
{
    class DatesRepository
    {
        private readonly HttpClient _httpClient;
        public DatesRepository()
        {
            _httpClient = new HttpClient
            {
                Timeout = TimeSpan.FromSeconds(10)
            };
        }
        public async Task<HttpResponseMessage> GetDatesInRangeAsync(string startDate, string endDate)
        {
            string apiUrl = $"https://localhost:7033/api/datesInRange/{startDate}/{endDate}";
            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Get, apiUrl))
                {

                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    return await _httpClient.SendAsync(requestMessage);
                }
            }
            catch (HttpRequestException ex) // Captura erro de rede/API
            {
                throw new Exception("Falha na comunicação com a API ao buscar DatesInRange.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar requisição para DatesInRange", ex);
            }
        }

        public async Task<HttpResponseMessage> PostDate(HttpContent content)
        {
            string apiUrl = $"https://localhost:7033/api/date";

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, apiUrl))
                {
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    requestMessage.Content = content;
                    return await _httpClient.SendAsync(requestMessage);
                }

            }
            catch (HttpRequestException ex) // Captura erro de rede/API
            {
                throw new Exception("Falha na comunicação com a API ao criar Dates.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar requisição para criar Date", ex);
            }
        }

        public async Task<HttpResponseMessage> PutDate(HttpContent content)
        {
            string apiUrl = $"https://localhost:7033/api/date";

            try
            {
                using (var requestMessage = new HttpRequestMessage(HttpMethod.Put, apiUrl))
                {
                    requestMessage.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", UserContext.Current.Token);
                    requestMessage.Content = content;
                    return await _httpClient.SendAsync(requestMessage);
                }

            }
            catch (HttpRequestException ex) // Captura erro de rede/API
            {
                throw new Exception("Falha na comunicação com a API ao atualizar Date.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar requisição para Date", ex);
            }
        }
    }
}
