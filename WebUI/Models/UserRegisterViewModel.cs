using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage="Lütfen adınızı Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı Giriniz")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adı Giriniz")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Lütfen mail adresi Giriniz")]
        public string Mail { get; set; }


        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Tekrar şifrenizi Giriniz")]
        [Compare("Password",ErrorMessage ="şifreler uyumlu değill")]
        public string ConfirmPassword { get; set; }
    }
}

