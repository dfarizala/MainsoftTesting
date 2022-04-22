using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MainsoftTesting.Models.CQRS.Response;
using System.Text;

namespace MainsoftTesting.Controllers
{
    public class UserListController : Controller
    {
        string _baseUrl = "https://mainsoftservices.azurewebsites.net/";
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
        public ActionResult Details(int id)
        {
            return View();
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

                string _Request = JsonConvert.SerializeObject(_userObject, Formatting.Indented);

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    HttpContent _Content = new StringContent(_Request);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage Res = await client.PostAsJsonAsync("User/AddUser", _Content);
                    if (Res.IsSuccessStatusCode)
                    {
                        var UserResponse = Res.Content.ReadAsStringAsync().Result;
                        _Result = JsonConvert.DeserializeObject<UserResponse>(UserResponse);
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
