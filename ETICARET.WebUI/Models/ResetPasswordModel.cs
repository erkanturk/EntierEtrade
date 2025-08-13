using System.ComponentModel.DataAnnotations;

namespace ETICARET.WebUI.Models
{
    public class ResetPasswordModel
    {
        public string Token { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]//üst yapıdaki password yapısı tipinde olmalı yani aynı yapıda olmalılar.
        public string RePassword { get; set; }
    }
}
