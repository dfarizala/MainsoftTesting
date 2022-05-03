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

namespace MainsoftTesting.Infrastructure.Exams
{
    public class Operations
    {
        static string _baseUrl = "https://mainsoftservices.azurewebsites.net/";

        async static public Task<GetExamsResponse> GetExams()
        {
            GetExamsResponse _Result = new GetExamsResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("Exam");
                if (Res.IsSuccessStatusCode)
                {
                    var UserList = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<GetExamsResponse>(UserList);
                }

                return _Result;
            }
        }

        async static public Task<GetAssignedExamsResponse> GetAssignedExams()
        {
            GetAssignedExamsResponse _Result = new GetAssignedExamsResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("Exam/GetAssigned", 0);
                if (Res.IsSuccessStatusCode)
                {
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<GetAssignedExamsResponse>(UserResponse);

                    if (!_Result.Success)
                        return null;
                }

                return (_Result);
            }
        }

    }
}
