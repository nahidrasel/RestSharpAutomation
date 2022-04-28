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

            
            var restResponse = restClient.ExecuteGetAsync(restRequest);

           // RestResponse content1 = ;
            //var users = JsonConvert.DeserializeObject<ListOfUsersDTO>();
        
        }
    }

}
