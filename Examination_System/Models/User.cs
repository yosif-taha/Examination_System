using System.ComponentModel.DataAnnotations;

namespace Examination_System.Models
{
    public class User : BaseModel<Guid>
    {
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        [EmailAddress(ErrorMessage ="Email Is Not Valid")]
        public string Email { get; set; } = null!;
        [Required]
        public string password { get; set; } = null!;

    }
}
