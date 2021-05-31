using SchoolRegistrationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolRegistrationSystem.ViewModel
{
    public class StudentViewModel
    {
        private readonly ISchoolRepository schoolRepository;
        public string SeachStudent { get; set; }
        public IEnumerable<Students> Students { get; set; }

        //public void OnGet()
        //{
        //    Students = schoolRepository.Search(SeachStudent);
        //}
    }
}
