using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Games
{
    public interface IGameService
    {
        void ListGame();
        void InsertGame(Game game);
        void UpdateGame(Game game, double GamePrice);
        void DeleteGame(Game game);

    }
}
