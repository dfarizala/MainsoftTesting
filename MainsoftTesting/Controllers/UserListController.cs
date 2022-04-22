using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MainsoftTesting.Models.CQRS.Request;
using MainsoftTesting.Models.CQRS.Response;
using System.Text;

namespace MainsoftTesting.Controllers
{
    public class UserListController : Controller
    {
        string _baseUrl = "https://mainsoftservices.azurewebsites.net/";
        //string _baseUrl = "https://localhost:7202/";
        // GET: UserListController
        async public Task<ActionResult> Index()
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

                return View(_Result.Users);
            }
        }

        // GET: UserListController/Details/5
        async public Task<ActionResult> Details(int id)
        {
            UserDetailResponse _Result = new UserDetailResponse();
            
            UserDetailRequest _Request = new UserDetailRequest { Id = id.ToString() };

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Clear();
                //HttpContent _Content = new JsonContent(_Request, );
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.PostAsJsonAsync("User/UserDetail", _Request);
                if (Res.IsSuccessStatusCode)
                {
                    var UserResponse = Res.Content.ReadAsStringAsync().Result;
                    _Result = JsonConvert.DeserializeObject<UserDetailResponse>(UserResponse);

                    if (!_Result.Success)
                        return View();
                }

                return View(_Result.User);
            }

        }

        // GET: UserListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserListController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        async public Task<ActionResult> Create(IFormCollection collection)
        {
            UserResponse _Result = new UserResponse();

            try
            {
                Models.CreateUserViewModel _userObject = 
                    new Models.CreateUserViewModel { AcademicInstitution = collection["AcademicInstitution"].ToString(),
                                                     Address = collection["Address"].ToString(),
                                                     AcademicLevel = collection["AcademicLevel"].ToString(),
                                                     Age = Convert.ToInt32(collection["Age"].ToString()),
                                                     BirthCity = collection["BirthCity"].ToString(),
                                                     CellPhone = collection["CellPhone"].ToString(),
                                                     DegreeFinalization = collection["DegreeFinalization"].ToString(),
                                                     DegreeTitle = collection["DegreeTitle"].ToString(),
                                                     DocNumber = collection["DocNumber"].ToString(),
                                                     DocType = collection["DocType"].ToString(),
                                                     Gender = collection["Gender"].ToString(),
                                                     JobSituation = collection["JobSituation"].ToString(),
                                                     LastJobCity = collection["LastJobCity"].ToString(),
                                                     LastJobCompany = collection["LastJobCompany"].ToString(),
                                                     LastJobName = collection["LastJobName"].ToString(),
                                                     LastJobReasson = collection["LastJobReasson"].ToString(),
                                                     LastName = collection["LastName"].ToString(),
                                                     MaritalStatus = collection["MaritalStatus"].ToString(),
                                                     Name = collection["Name"].ToString(),
                                                     Nationality = collection["Nationality"].ToString(),
                                                     Phone = collection["Phone"].ToString()
                    };

                //string _Request = JsonConvert.SerializeObject(_userObject, Formatting.Indented);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    //HttpContent _Content = new JsonContent(_Request, );
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.PostAsJsonAsync("User/AddUser", _userObject);
                    if (Res.IsSuccessStatusCode)
                    {
                        var UserResponse = Res.Content.ReadAsStringAsync().Result;
                        _Result = JsonConvert.DeserializeObject<UserResponse>(UserResponse);

                        if (!_Result.Success)
                            return View();
                    }

                    return RedirectToAction(nameof(Index));
                }

            }
            catch
            {
                return View();
            }
        }

        // GET: UserListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserListController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserListController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
