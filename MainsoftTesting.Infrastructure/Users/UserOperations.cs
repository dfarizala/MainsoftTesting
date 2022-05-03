using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;
using System.Text;
using System.Net.Http.Json;

namespace MainsoftTesting.Infrastructure.Users
{
    public class Operations
    {
        static string _baseUrl = "https://mainsoftservices.azurewebsites.net/";

        async static public Task<UserListResponse> GetUserList()
        {
            UserListResponse _Result = new UserListResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("User");
                if (Res.IsSuccessStatusCode)
                {
                    var UserList = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<UserListResponse>(UserList);
                }

                return _Result;
            }
        }

        async static public Task<UserDetailResponse> GetUserDetails(int id)
        {
            UserDetailResponse _Result = new UserDetailResponse();

            UserDetailRequest _Request = new UserDetailRequest { Id = id.ToString() };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("User/UserDetail", _Request);
                if (Res.IsSuccessStatusCode)
                {
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<UserDetailResponse>(UserResponse);

                    if (!_Result.Success)
                        return null;
                }

                return (_Result);
            }
        }

        async static public Task<UserResponse> CreateNewUser(Domain.Models.CreateUserViewModel objUser)
        {
            UserResponse _Result = new UserResponse();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                //HttpContent _Content = new JsonContent(_Request, );
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("User/AddUser", objUser);
                if (Res.IsSuccessStatusCode)
                {
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<UserResponse>(UserResponse);

                    if (!_Result.Success)
                        throw new Exception("Error saving record");
                }

                return _Result;
            }

        }
    }
}