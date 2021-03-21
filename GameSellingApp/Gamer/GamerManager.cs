using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Gamer
{
    public class GamerManager : IGamerService
    {
        private List<GamerEntity> _gamerList;

        public GamerManager()
        {
            _gamerList = new List<GamerEntity>();
        }
        public void DeleteGamer(GamerEntity gamer)
        {
            _gamerList.Remove(gamer);
            Console.WriteLine(gamer.FirstName + " was removed");
        }

        public void ListGamer()
        {
            Console.WriteLine("-------------------  REGISTERED GAMERS  --------------------");
            foreach (var gamer in _gamerList)
            {
                Console.WriteLine(gamer.GamerId + "  " + gamer.FirstName + " " + gamer.LastName.ToUpper() + "  " + gamer.DateOfBirth);
            }
            Console.WriteLine("--------------   END OF REGISTERED GAMER LIST   -------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void RegisterGamer(GamerEntity gamer)
        {
            _gamerList.Add(gamer);
            Console.WriteLine(gamer.FirstName + " has been added to database.");
        }

        public void UpdateGamer(GamerEntity gamer, string FirstName)
        {
            gamer.FirstName = FirstName;
            Console.WriteLine(gamer.FirstName + " has been updated.");
        }
    }
}
