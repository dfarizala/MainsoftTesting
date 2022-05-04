using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;
using System.Net.Http.Json;
using MainsoftTesting.Domain.CQRS.Request;

namespace MainsoftTesting.Infrastructure
{
    public class MailOperations
    {
        static string _baseUrl = "https://mainsoftservices.azurewebsites.net/";

        async static public Task<bool> SendMail(MailRequest request)
        {
            GetAssignedExamsResponse _Result = new GetAssignedExamsResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("Mail/SendMail", request);
                if (Res.IsSuccessStatusCode)
                {   
                    return true;
                }

                return (false); 
            }
        }

    }
}
