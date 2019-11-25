using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_AuthenticationService.Models
{
    public class Training
    {
        [Key]
        public string Training_id { get; set; }
        [ForeignKey("Student")]
        public long Student_Id { get; set; }
        [ForeignKey("Mentor")]
        public long MentorId { get; set; }
        [ForeignKey("Technology")]
        public long Tech_id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string timeslot { get; set; }
        public Student Student { get; set; }
        public Mentor Mentor { get; set; }
        public Technology Technology { get; set; }
    }
}
