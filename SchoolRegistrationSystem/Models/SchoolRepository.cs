using SchoolRegistrationSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistrationSystem.Models
{
    public class SchoolRepository : ISchoolRepository
    {
        private readonly SchoolRegistrationContext _context;

        public SchoolRepository(SchoolRegistrationContext context)
        {
            this._context = context;
        }
        public Students GetStudents(int id)
        {
            return _context.Students.Find(id);
            //return _context.Students.FirstOrDefault(a => a.StudentID == StudentID);
        }
        public IEnumerable<CourseStudentViewModel> GetStudentEnrolled(int id)
        {
            var result = _context.Registration.Where(x => x.CourseId == id).Select(m => m.StudentId);
            List<CourseStudentViewModel> enrolled = new List<CourseStudentViewModel>();
            for (int i = 0; i < enrolled.Count - 1; i++)
            {
                if (enrolled[i].CourseId == id)
                {
                    var mylist = enrolled[i].StudentId;
                   
                }

            }
            return enrolled;
        }

        public IEnumerable<Students> Search(string SeachStudent)
        {
           if(string.IsNullOrEmpty(SeachStudent))
            {
                return _context.Students;
            }

            return _context.Students.Where(e => e.FirstName.Contains(SeachStudent) || e.LastName.Contains(SeachStudent));
                                            
        }

        //public Students GetByCourse(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Courses> GetEnrolees(int id)
        //{
        //    var courseDetails = _context.Courses.Where(a => a.CourseId == Courses).Include(a => a.Students).ToListAsync();
        //     return(courseDetails);
        //}
    }
}
