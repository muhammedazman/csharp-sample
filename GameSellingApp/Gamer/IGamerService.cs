using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Gamer
{
    public interface IGamerService
    {
        void ListGamer();
        void RegisterGamer(GamerEntity gamer);
        void DeleteGamer(GamerEntity gamer);
        void UpdateGamer(GamerEntity gamer, string FirstName);
    }
}
