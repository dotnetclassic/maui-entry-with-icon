using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestApp.Api
{
    public static class LoginService
    {
        public static async Task<bool> LoginCheck(string email)
        {
            try 
            {
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(email);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("http://192.168.18.6:8086/auth?email=" + email, content);
                //var response = await httpClient.PostAsync("http://localhost:59037/auth?email=" + email, content);
             
                if (!response.IsSuccessStatusCode)
                {
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {

                return false;
            }
            
        }
    }
}
