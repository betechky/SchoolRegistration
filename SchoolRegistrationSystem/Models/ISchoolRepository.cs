using SchoolRegistrationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistrationSystem.Models
{
    public interface ISchoolRepository
    {
        IEnumerable<Students> Search(string SeachStudent);
        IEnumerable<CourseStudentViewModel> GetStudentEnrolled(int id);
        //IEnumerable<Courses> GetEnrolees(int id);
        public Students GetStudents(int id);
       
    }
}
