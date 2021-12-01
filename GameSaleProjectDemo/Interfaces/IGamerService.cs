using GameSaleProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Interfaces
{
    interface IGamerService
    {
        void Register(Gamer gamer);
        void DeleteGamer(Gamer gamer);
        void UpdateGamer(Gamer gamer);
    }
}
