using System.ComponentModel.DataAnnotations;

namespace AspNet_kt7.Models.ViewModels
{
    public class EditUserViewModel
    {
        [Required]
        public string Id { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Имя обязательно")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Роль обязательна")]
        public string Role { get; set; } = string.Empty;
    }
}