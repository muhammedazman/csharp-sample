using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager(new UserValidationManager());
            gameManager.Add(new Gamer { 
                Id = 1, 
                IdentityNumber=12345, 
                FirstName="MUHAMMED", 
                LastName="AZMAN", 
                BirthYear=1985}
            );
            Console.WriteLine("Hello World!");
        }
    }
}
