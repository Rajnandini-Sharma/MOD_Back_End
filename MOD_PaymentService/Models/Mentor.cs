using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Models
{
    public class Mentor
    {
        [Key]
        public long MentorId { get; set; }
        [Required]
        public string MentorName { get; set; }
        [Required]
        public string Mentor_email { get; set; }
        [Required]
        public int Mentor_Contact { get; set; }
        [Required]
        public string Mentor_Password { get; set; }
        [Required]
        public string Mentor_Experience { get; set; }
        public string Mentor_skills { get; set; }
        public string From_Time_slot { get; set; }
        public string To_Time_slot { get; set; }
        public bool? Mentor_Avail { get; set; }
        public bool? Mentor_active { get; set; }

        public IEnumerable<Payment> Payments { get; set; }

        public IEnumerable<Training> Trainings { get; set; }
    }
}
