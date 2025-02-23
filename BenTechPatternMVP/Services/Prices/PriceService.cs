using BenTechPatternMVP.DTO.Prices;
using BenTechPatternMVP.Repository.Prices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Services.Prices
{
    class PriceService
    {
        private readonly PriceRepository _repository;
        public PriceService()
        {
            _repository = new PriceRepository();


        }


        public async Task<List<IPriceDTO>> GetAllPrices()
        {
            try
            {
                HttpResponseMessage response = await _repository.GetAllPricesAsync();
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {

                    var pricesList = JsonConvert.DeserializeObject<List<PriceDTO>>(responseString);

                    return pricesList.Cast<IPriceDTO>().ToList();
                }
                else
                {
                    return new List<IPriceDTO>
                    {
             new PriceDTO { ErrorMessage = responseString }
                    };
                }
            }
            catch (Exception ex)
            {
                return new List<IPriceDTO>
                {
                 new PriceDTO { ErrorMessage = ex.Message }
                };
            }
        }
    }
}
