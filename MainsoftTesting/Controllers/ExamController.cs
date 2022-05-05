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
using MainsoftTesting.Application.Exam;
using System.Text;
using MainsoftTesting.Domain.Models;
using MainsoftTesting.Domain.CQRS.Request;

namespace MainsoftTesting.Controllers
{
    public class ExamController : Controller
    {
        // GET: ExamController<
        async public Task<ActionResult> Index()
        {
            GetExamsResponse _Result = new GetExamsResponse();

            _Result = await Operations.GetExam();

            return View(_Result.Exams);
        }


        // GET: ExamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ExamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamController/Edit/5
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

        // GET: ExamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamController/Delete/5
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

        async public Task<ActionResult> Assigned()
        {
            GetAssignedExamsResponse _Result = new GetAssignedExamsResponse();

            _Result = await Operations.GetAssignedExam();

            return View(_Result.Assignment);
        }

        async public Task<ActionResult> Assign(int id, int userId)
        {
            UserDetailResponse _Result = new UserDetailResponse();
            GetExamsResponse _Exams = new GetExamsResponse();

            if (userId == 0)
            {

                _Exams = await Operations.GetExam();
                _Result = await Application.User.Operations.GetUserDetails(id);

                ViewBag.UserObject = _Result.User;
                return View(_Exams.Exams);
            }
            else
            {
                AssignExamRequest request = new AssignExamRequest();
                request.idUser = userId;
                request.idExam = id;
                request.Recruiter = "1";

                var _Asignation = await Application.Exam.Operations.AssignExam(request);
                if (_Asignation.Success)
                {
                    _Result = await Application.User.Operations.GetUserDetails(userId);

                    string _BaseUrl = "https://testingmainsoft.azurewebsites.net";
                    string _UserData = userId + "-" + id + "-" + System.DateTime.Now.Date.ToString();
                    string _Token = Application.Crypto.EncryptString(_UserData);
                    string _Link = _BaseUrl + "/Default?tokenId=" + _Token;
                    string _Body = "Link para el examen: " + _Link;
                    string _Subject = "Prueba para " + _Result.User.LastName + " " + _Result.User.Name;


                    MailRequest _MailObj = new MailRequest { FromEmail = "dfarizala@gmail.com",
                        Body = _Body, Subject =  _Subject, ToEmail = _Result.User.Email };
                    bool _Mail = await Application.MailOperations.SendMail(_MailObj);

                }
                return RedirectToAction(nameof(Assigned));
            }
        }

    }
}
