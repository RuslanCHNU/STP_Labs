using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using System.Collections.Generic;
using System.ServiceModel.Activation;
using CustomerService;

namespace StudentService
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class StudentService : IStudentService
    {
        public List<Student> GetStudentList()
        {
            return PopulateStudentData();
        }

        private List<Student> PopulateStudentData()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                StudentCardNumber = 101,
                FullName = "Іван Петренко",
                Course = 3
            });

            students.Add(new Student
            {
                StudentCardNumber = 102,
                FullName = "Марія Сидоренко",
                Course = 2
            });

            return students;
        }
    }
}