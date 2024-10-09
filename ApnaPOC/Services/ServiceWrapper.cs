using ApnaKhata.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ApnaPOC.Services
{
    internal class ServiceWrapper
    {

        public async Task<T> GetServiceCall<T>(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<T>();
            }
            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
