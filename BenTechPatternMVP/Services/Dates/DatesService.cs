using BenTechPatternMVP.Model.Days.CalendarDay;
using BenTechPatternMVP.Model.Days.DateDTO;
using BenTechPatternMVP.Repository.Dates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Services.Dates
{
    class DatesService
    {
        private readonly DatesRepository _repository;

        public DatesService()
        {
            _repository = new DatesRepository();
        }
        public async Task<List<DateDTO>> GetDatesInRange(string startDate, string endDate)
        {
            try
            {
                HttpResponseMessage response = await _repository.GetDatesInRangeAsync(startDate, endDate);
                var resposeString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var datesList = JsonConvert.DeserializeObject<List<DateDTO>>(resposeString);
                    return datesList.Cast<DateDTO>().ToList();
                }
                else
                {
                    return null;
                }

            }

            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado em DatesService DatesInRange", ex);
            }
        }
        public async Task CreateDate(string date, string coloCode)
        {
            try
            {
                var dateDTO = new DateDTO
                {
                    Date = date,
                    ColorCode = coloCode
                };
                var jsonContent = JsonConvert.SerializeObject(dateDTO);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _repository.PostDate(content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao criar Date: {errorMessage}");
                }
            }

            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao criar Date", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao criar date", ex);
            }
        }


        public async Task UpdateDate(string date, string coloCode)
        {
            try
            {
                var dateDTO = new DateDTO
                {
                    Date = date,
                    ColorCode = coloCode
                };
                var jsonContent = JsonConvert.SerializeObject(dateDTO);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _repository.PutDate(content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao atualizar Date: {errorMessage}");
                }
            }

            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao atualizar Date", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao atualizar date", ex);
            }
        }
    }

}



