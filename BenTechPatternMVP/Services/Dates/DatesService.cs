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
    }

}

