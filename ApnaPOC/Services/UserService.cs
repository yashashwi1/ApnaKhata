using ApnaKhata.DataModels;
using GatewayInteractionContracts.Requests;
using GatewayInteractionContracts.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ApnaPOC.Services
{
    internal class UserService
    {

        private ServiceLocator serviceLocator;
        public UserService(ServiceLocator serviceLocator)
        {
            this.serviceLocator = serviceLocator;            
        }
        public async Task<User> GetUserDetails(string userName)
        {
            HttpClient client = new HttpClient();
            var getUserRequest = new GetUserRequest();
            getUserRequest.userId = "12";
            getUserRequest.userName = "yash";
           
            var request1 = JsonConvert.SerializeObject(getUserRequest);
            var request = new Request();
            request.requestType = (typeof(GetUserRequest)).ToString();
            request.payLoad = request1;
            var ss = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            var result = await client.PostAsync(this.serviceLocator.GetServiceBaseUrl(), ss);
            if (result.IsSuccessStatusCode)
            {
                var x = result.Content.ReadAsStringAsync().Result;
                var y = JsonConvert.DeserializeObject<Response>(x);
                var user = JsonConvert.DeserializeObject<GetUserResponse>(y.payload);
                return user.User;
            }
            return null;
        }
    }
}
