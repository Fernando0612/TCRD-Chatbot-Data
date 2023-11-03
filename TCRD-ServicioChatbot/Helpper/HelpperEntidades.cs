using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace TCRD_ServicioChatbot.Helpper
{
    public class HelpperEntidades
    {
        private readonly HttpClient _client;

        public HelpperEntidades()
        {
            _client = new HttpClient();
        }

        private readonly string _apiBaseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
        private readonly string _apiUsername = ConfigurationManager.AppSettings["ApiUsername"];
        private readonly string _apiToken = ConfigurationManager.AppSettings["ApiToken"];

        public async Task<string> GetFromApiAsync(string endpoint)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{_apiBaseUrl}{endpoint}");
            request.Headers.Add("username", _apiUsername);
            request.Headers.Add("token", _apiToken);

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<int> GetIntFromApiAsync(string endpoint)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string baseUrl = ConfigurationManager.AppSettings["ApiBaseUrl"];
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Add("username", ConfigurationManager.AppSettings["ApiUsername"]);
                    client.DefaultRequestHeaders.Add("token", ConfigurationManager.AppSettings["ApiToken"]);
                    var response = await client.GetAsync(endpoint);

                    if (response.IsSuccessStatusCode)
                    {
                        var stringResult = await response.Content.ReadAsStringAsync();
                        if (int.TryParse(stringResult, out int result))
                        {
                            return result;
                        }
                        else
                        {
                            throw new Exception("El resultado no es un número entero.");
                        }
                    }
                    else
                    {
                        throw new Exception($"Error en la petición: {response.StatusCode.ToString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos desde la API: {ex.Message}");
            }
        }





    }
}