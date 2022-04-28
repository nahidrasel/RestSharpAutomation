using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Demo
    {
        public ListOfUsersDTO GetUsers()
        {
            var restClient = new RestClient("https://reqres.in");
            var restRequest = new RestRequest("/api/users?page=2", Method.Get);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            
            var response = restClient.GetAsync(restRequest);
            var content = response.Result;


            var users = JsonConvert.DeserializeObject<ListOfUsersDTO>(content);
            return users;
        
        }
    }

}
