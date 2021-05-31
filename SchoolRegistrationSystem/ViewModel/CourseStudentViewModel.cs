using SchoolRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistrationSystem.ViewModel
{
    public class CourseStudentViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
       
        public int? CourseId { get; set; }
        public string CourseNumber { get; set; }
        public string CourseName { get; set; }

        public int? StudentId { get; set; }    
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public Courses Courses { get; set; }
        public Students Student { get; set; }
        public ICollection<Courses> Enrollments { get; set; }
        public ICollection<Students> Students { get; set; }

    }
}
