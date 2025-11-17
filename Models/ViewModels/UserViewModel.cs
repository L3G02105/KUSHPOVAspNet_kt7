using System.ComponentModel.DataAnnotations;

namespace AspNet_kt7.Models.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Некорректный email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Имя обязательно")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Роль обязательна")]
        public string Role { get; set; } = string.Empty;
    }
}