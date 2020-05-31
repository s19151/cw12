using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cwiczenia12.Models
{
    public partial class Student
    {
        [Display(Name = "Student Index")]
        public string IndexNumber { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int IdEnrollment { get; set; }
        public string Password { get; set; }

        [Display(Name = "Id Enrollment")]
        public virtual Enrollment IdEnrollmentNavigation { get; set; }
    }
}
