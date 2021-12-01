using GameSaleProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Interfaces
{
    interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
