using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MOD_PaymentService.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        [ForeignKey("Student")]
        public long Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string MentorName { get; set; }
        [ForeignKey("Mentor")]
        public long MentorId { get; set; }
        //[ForeignKey("Training")]
        //public string Training_id { get; set; }
        public float Amount { get; set; }
        public float AmountMentor { get; set; }
        public Student Student { get; set; }
        public Mentor Mentor { get; set; }
        // public Training Training { get; set; }
    }
}
