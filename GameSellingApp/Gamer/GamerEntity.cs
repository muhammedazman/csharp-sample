using GameSellingApp.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Gamer
{
    public class GamerEntity
    {
        public GamerEntity()
        {
            GameBought = new List<Game>();
        }

        public int GamerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NatioanlityId { get; set; }
        public List<Game> GameBought { get; set; }
    }
}
