using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MOD_AuthenticationService.Models
{
    public class Student
    {
        [Key]
        public long Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string Student_email { get; set; }
        public int Student_Contact { get; set; }
        public string Student_Password { get; set; }
        public bool? Student_active { get; set; }
        public IEnumerable<Training> Trainings { get; set; }
        public IEnumerable<Payment> Payments { get; set; }
    }
}
