using BenTechPatternMVP.DTO;
using BenTechPatternMVP.Repository.Login;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BenTechPatternMVP.Services.Login
{
    public class LoginService: ILoginService
    {
        private readonly LoginRepository _loginRepository;
        public LoginService()
        {
            _loginRepository = new LoginRepository();
        }


        public async Task<LoginDTO> Login(string username, string password)
        {
            try
            {
                HttpResponseMessage response = await _loginRepository.GetUserLoginAsync(username, password);
                var responseString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                  
                    var loginResponse = JsonConvert.DeserializeObject<LoginDTO>(responseString);

                    return new LoginDTO
                    {
                        Name = loginResponse.Name,
                        Token = loginResponse.Token,
                        IsAdmin = loginResponse.IsAdmin
                    };
                }
                else
                {
                    return new LoginDTO
                    {
                        ErrorMessage = responseString
                    };
                }
            }
            catch (Exception ex)
            {
                return new LoginDTO
                {
                    ErrorMessage = ex.Message
                };
            }
        }

    }
}

