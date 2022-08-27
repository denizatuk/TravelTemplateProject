using System;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {

                Code = "PasswordTooShort",
                Description = $"Parola minumum {length} karakter olmalıdır"
            };              
            
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiredUpper",
                Description = $"Parola en az 1 Büyük harf içermelidir"
            };
            
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiredLower",
                Description = "Parola en az 1 küçük harf içermelidir"
            };
            

        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumaric",
                Description = "Parola en az 1 sembol harf içermelidir"
            };
        }
    }
}

