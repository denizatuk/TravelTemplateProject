using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage="Lutfen Kullanici Adini Giriniz.")]
        public string username { get; set; }
        [Required(ErrorMessage ="Lutfen Sifrenizi Giriniz")]
        public string password { get; set; }
    }
}

