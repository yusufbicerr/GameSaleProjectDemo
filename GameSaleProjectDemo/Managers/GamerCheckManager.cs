using GameSaleProjectDemo.Entities;
using GameSaleProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Managers
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if (gamer.TcNo == "12345678900" && gamer.Name == "Yusuf" && gamer.Id == 1 && gamer.BirthDate == "04.12.2001")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
