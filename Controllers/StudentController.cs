using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Mvc;  // For .NET Core and newer
using StudentManagementApp.Models;

namespace StudentManagementApp.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository repository = new StudentRepository();

        // GET: Student
        public ActionResult Index()
        {
            var students = repository.GetAllStudents();
            return View(students);
        }

        // GET: Student/Details/1
        public ActionResult Details(int id)
        {
            var student = repository.GetStudentById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                repository.AddStudent(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }
    }

}
