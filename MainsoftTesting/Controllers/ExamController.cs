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
            if (userId == 0)
            {
                UserDetailResponse _Result = new UserDetailResponse();
                GetExamsResponse _Exams = new GetExamsResponse();

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

                var _Result = await Application.Exam.Operations.AssignExam(request);
                return RedirectToAction(nameof(Assigned));
            }
        }

    }
}
