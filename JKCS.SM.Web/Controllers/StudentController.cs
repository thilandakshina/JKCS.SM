using AutoMapper;
using JKCS.SM.BusinessServices.Contract;
using JKCS.SM.Domain;
using JKCS.SM.Web.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace JKCS.SM.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }


        public ActionResult GetList()
        {
            List<Student> student = new List<Student>();

            student = _studentManager.GetStudentList();

         //   List<StudentViewModel> studentViewModel = Mapper.Map<List<Student>, List<StudentViewModel>>(student);

            var jsonResult = JsonConvert.SerializeObject(student);
            return Content(jsonResult, "application/json");

        }

        [ResponseType(typeof(StudentViewModel))]
        public IHttpActionResult Update(StudentViewModel student)
        {
            if (student.FirstName != null)
            {
                //  Student students = Mapper.Map<StudentViewModel, Student>(student);
                //  _studentManager.AddStudent(students);
                //  return RedirectToAction("Index", "Student");
            }

            return null;

        }

        [ResponseType(typeof(StudentViewModel))]
        public IHttpActionResult Create(StudentViewModel student)
        {
            if (student.FirstName != null)
            {
              //  Student students = Mapper.Map<StudentViewModel, Student>(student);
              //  _studentManager.AddStudent(students);
              //  return RedirectToAction("Index", "Student");
            }

            return null;

        }
    }
}