using System.ComponentModel.DataAnnotations.Schema;
using VeterinaryAPIWebApp.Models;

namespace VeterinaryAPIWebApp.Models
{
    public class VisitService
    {
        public int Id { get; set; }

        [ForeignKey("Visit")]
        public int VisitId { get; set; }
        public Visit? Visit { get; set; }

        [ForeignKey("Service")]
        public int ServiceId { get; set; }
        public Service? Service { get; set; }

    }
}