using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestProject.Models.ViewModel
{
    public class TeacherVM
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public double Salary { get; set; }
        public string SubjectTaught { get; set; }
        public bool IsPermanent { get; set; }
    }
}
