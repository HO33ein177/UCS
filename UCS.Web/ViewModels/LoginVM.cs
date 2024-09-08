using System.ComponentModel.DataAnnotations;

namespace UniCourseSelect.ViewModels
{
    public class LoginVM
    {
        [Required]
        public long UniqueMemberId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public string? RedirectUrl { get; set; }
    }
}
