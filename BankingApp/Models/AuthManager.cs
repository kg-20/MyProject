using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BankingApp.Models
{
    public class AuthManager
    {
        const string Url = "http://banking-ucenfotec-api.azurewebsites.net/api/v1/Auth/Login";

        public AuthManager()
        {
        }
        /*
        public async Task<BankingUser> Login(string email, string psw)
        {
            Auth auth = new Auth()
            {
                Email = email,
                Password = psw
            };

            //EJEMPLO TOMADO DE http://blog.xhackers.co/httpclient-with-xamarin-forms/

            HttpClient client = new HttpClient();

            var data     = JsonConvert.SerializeObject(auth);
            var content  = new StringContent(data, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(Url, content);

            var result = JsonConvert.DeserializeObject<BankingUser>(await response.Content.ReadAsStringAsync().Result);

            return result;
        }
*/
    }
}
