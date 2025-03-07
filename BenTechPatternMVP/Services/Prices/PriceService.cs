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
            catch (HttpRequestException ex)
            {
                return new List<IPriceDTO> { new PriceDTO { ErrorMessage = $"Falha na comunicação com a API: {ex.Message}" } };
            }
            catch (Exception ex)
            {
                return new List<IPriceDTO> { new PriceDTO { ErrorMessage = $"Erro inesperado: {ex.Message}" } };
            }
        }

        public async Task UpdatePrice(IPriceDTO price)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(price);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _repository.UpdatePriceAsync(content);

                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao atualizar preço: {errorMessage}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao atualizar preço", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao atualizar preço", ex);
            }
        }

        public async Task DeletePrice(string colorCode)
        {
            try
            {
                await _repository.DeletePriceAsync(colorCode);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao excluir preço", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao excluir preço", ex);
            }
        }

        public async Task CreatePrice(IPriceDTO price)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(price);
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _repository.CreateNewPriceAsync(content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao criar preço: {errorMessage}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao criar preço", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao criar preço", ex);
            }

        }
    }
}
