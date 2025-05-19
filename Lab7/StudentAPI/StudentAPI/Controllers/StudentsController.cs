using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    public class StudentsController : ApiController
    {
        List<Student> students = new List<Student>
        {
            new Student { StudentCardNumber = 101, FullName = "Іван Петренко", Course = 3 },
            new Student { StudentCardNumber = 102, FullName = "Марія Сидоренко", Course = 2 }
        };

        // GET: api/students
        public IEnumerable<Student> GetAllStudents()
        {
            return students;
        }

        // GET: api/students/101
        public IHttpActionResult GetStudent(int id)
        {
            var student = students.Find(s => s.StudentCardNumber == id);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
    }
}