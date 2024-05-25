using System.ComponentModel.DataAnnotations;

namespace VeterinaryAPIWebApp.Models
{
    public class Patient
    {
        public Patient()
        {
            Visits = new List<Visit>();
            Breed = string.Empty;
            Gender = string.Empty;
            OwnerEmail = string.Empty;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ім'я")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Вид тварини")]
        public string? Species { get; set; }

        [Display(Name = "Порода")]
        public string Breed { get; set; }

        [Display(Name = "Стать")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Дата народження")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ім'я власника")]
        public string? OwnerName { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Прізвище власника")]
        public string? OwnerSurname { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Номер телефону власника")]
        public string? OwnerPhone { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Адреса власника")]
        public string? OwnerAddress { get; set; }

        [Display(Name = "Email власника")]
        public string OwnerEmail { get; set; }

        public virtual ICollection<Visit> Visits { get; set; }
    }
}
