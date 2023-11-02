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
            // Agrega cualquier otro encabezado que necesites aquí

            var response = await _client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }





    }
}