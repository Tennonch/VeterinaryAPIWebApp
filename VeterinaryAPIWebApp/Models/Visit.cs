using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using VeterinaryAPIWebApp.Models;

namespace VeterinaryAPIWebApp.Models
{
    public class Visit
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Дата візиту")]
        [DataType(DataType.Date)]
        public DateTime VisitDate { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Час візиту")]
        [DataType(DataType.Time)]
        public TimeSpan VisitTime { get; set; }

        [ForeignKey("Patient")]
        [Display(Name = "Пацієнт")]
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        [ForeignKey("Doctor")]
        [Display(Name = "Лікар")]
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Опис візиту")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Діагноз")]
        public string? Diagnosis { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Лікування")]
        public string? Treatment { get; set; }
    }
}
