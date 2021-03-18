using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1985 && gamer.IdentityNumber == 12345
                && gamer.FirstName == "MUHAMMED" && gamer.LastName == "AZMAN")
            {
                Console.WriteLine("Validation Manager Calisti");
                return true;
            } 
            else
            {
                Console.WriteLine("Validation Manager Hata Alindi");
                return false;
            }
        }
    }
}
