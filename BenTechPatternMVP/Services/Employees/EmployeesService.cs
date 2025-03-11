using BenTechPatternMVP.DTO.Employee;
using BenTechPatternMVP.Repository.Employees;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Services.Employees
{
    class EmployeesService
    {
        private readonly EmployeesRepository _employeesRepository;
        public EmployeesService()
        {
            _employeesRepository = new EmployeesRepository();
        }

        public async Task<List<EmployeeDTO>> GetAllEmployeesAsync()
        {
            try
            {
                HttpResponseMessage response = await _employeesRepository.GetAllEmployeesAsync();
                var responseString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {

                    var EmployeeList = JsonConvert.DeserializeObject<List<EmployeeDTO>>(responseString);
                    return EmployeeList.Cast<EmployeeDTO>().ToList();
                }
                else return null;


            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado em EmployeesService EmployeesInRange", ex);
            }
        }

        public async Task CreateEmployee(EmployeeDTO employeeDTO)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(employeeDTO);
                StringContent content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _employeesRepository.CreateNewEmployeeAsync(content);
                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao criar Employee: {errorMessage}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao criar Employee", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao criar Employee", ex);
            }
        }

        public async Task DeletePrice(Guid id)
        {
            try
            {
                await _employeesRepository.DeleteEmployeeAsync(id);
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao excluir Employee", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao excluir Employee", ex);
            }
        }

        public async Task UpdatePrice(EmployeeUpdateDTO employeeUpdateDTO)
        {
            try
            {
                var jsonContent = JsonConvert.SerializeObject(employeeUpdateDTO);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _employeesRepository.UpdateEmployeeAsync(content);

                if (!response.IsSuccessStatusCode)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Erro ao atualizar employee: {errorMessage}");
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception("Falha na comunicação com a API ao atualizar employee", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado ao atualizar premployeeeço", ex);
            }
        }
    }
}
