using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Games
{
    public class GameManager : IGameService
    {

        private List<Game> _gameList;

        public GameManager()
        {
            _gameList = new List<Game>();
        }

        public void InsertGame(Game game)
        {
            _gameList.Add(game);
            Console.WriteLine(game.GameName + " has been added.");
        }

        public void DeleteGame(Game game)
        {
            _gameList.Remove(game);
            Console.WriteLine(game.GameName + "  was removed");
        } 

        public void ListGame()
        {
            Console.WriteLine("---------------GAMES SAVED TO THE DATABASE----------");
            foreach (var game in _gameList)
            {
                Console.WriteLine(game.GameId + "  " + game.GameName + " " + game.GamePrice);
            }
            Console.WriteLine("---------------END OF THE GAME LIST----------------");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void UpdateGame(Game game, double GamePrice)
        {
            game.GamePrice = GamePrice;
            Console.WriteLine("Updated : " + game.GameName + " Price: " + game.GamePrice);
        }
    }
}
