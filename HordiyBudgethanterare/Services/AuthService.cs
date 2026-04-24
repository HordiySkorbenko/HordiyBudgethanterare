using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using HordiyBudgethanterare.Models;

namespace HordiyBudgethanterare.Services
{
    internal class AuthService
    {
        private string url = "https://api.jsonbin.io/v3/b/69eb2b13aaba882197317bce";
        private string apiKey = "$2a$10$AP3Rh/9QHbQPUe9edVq0AOI4hH/ESOBtudD29IH7ggci282Z2l7e2";

        private HttpClient client = new HttpClient();

        public AuthService()
        {
            client.DefaultRequestHeaders.Add("X-Master-Key", apiKey); //skickar in apinyckeln när requesten skickas
        }

        //funktionen hämtar upp data om alla användare
        public async Task<List<User>> GetUsers()
        {
            var response = await client.GetStringAsync(url);
            dynamic data = JsonConvert.DeserializeObject(response);
            return JsonConvert.DeserializeObject<List<User>>(data.record.users.ToString());
        }

        public bool login(string username, string password)
        {

        }

    }
}
