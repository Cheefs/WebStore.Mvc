using System.ComponentModel.DataAnnotations;

namespace WebStore.Mvc.Models
{
    public class EmployeViewModel
    {
        public int? Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string? LastName { get; set; }

        [Required]
        [MaxLength(10)]
        public string? FirstName { get; set; }
        public string? Patronymic { get; set; }

        [Required]
        public int? Age { get; set; }
    }
}
