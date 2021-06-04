using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StuFirstName { get; set; }
        public string StuLastName { get; set; }
        public int StuAge { get; set; }

        [DataType(DataType.Date)]
        public DateTime StuEnrollDate { get; set; }

    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseCapacity { get; set; }
        public int CourseCountEnrollment { get; set; }

    }

    public class Department
    {
        public int DepID { get; set; }
        public string DepName { get; set; }
        public int DepChair { get; set; }
    }
}
