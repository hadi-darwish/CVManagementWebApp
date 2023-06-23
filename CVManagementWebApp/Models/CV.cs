using System.ComponentModel.DataAnnotations;

namespace CVManagementWebApp.Models
{
    public class CV
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string? LastName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "Date Of Birth")]
        [Required]
        public string? Nationality { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? ProgrammingSkills { get; set; }
        [Display(Name = "Programming Skills")]
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Photo { get; set; }
    }
}
