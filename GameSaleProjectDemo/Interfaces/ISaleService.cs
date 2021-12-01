using GameSaleProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Interfaces
{
    interface ISaleService
    {
        void Sell(Gamer gamer, Item item);
    }
}
