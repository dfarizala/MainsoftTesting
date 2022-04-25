using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using MainsoftTesting.Domain.Models.CQRS.Request;
using MainsoftTesting.Domain.Models.CQRS.Response;
using MainsoftTesting.Application.User;
using System.Text;

namespace MainsoftTesting.Controllers
{
    public class UserListController : Controller
    {

        // GET: UserListController
        async public Task<ActionResult> Index()
        {
            UserListResponse _Result = new UserListResponse();

            _Result = await Operations.GetUserList();
            
            return View(_Result.Users);                        
        }

        // GET: UserListController/Details/5
        async public Task<ActionResult> Details(int id)
        {
            UserDetailResponse _Result = new UserDetailResponse();

            _Result = await Operations.GetUserDetails(id);

            return View(_Result.User);            
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
                Domain.Models.CreateUserViewModel _userObject = 
                    new Domain.Models.CreateUserViewModel { AcademicInstitution = collection["AcademicInstitution"].ToString(),
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

                _Result = await Operations.CreateNewUser(_userObject);
                if (!_Result.Success)
                    throw new Exception(_Result.Message);

                return RedirectToAction(nameof(Index));
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
