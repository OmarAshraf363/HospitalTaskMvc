using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcTask01.Models
{
    public class Appointments
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="*")]
        public string PatientName {  get; set; }
        public string PatientPhone {  get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time {  get; set; }

        [ForeignKey(nameof(DoctorId))]
        public int DoctorId {  get; set; }
        public Doctor Doctor { get; set; }
    
    }
}
