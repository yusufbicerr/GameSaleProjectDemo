using GameSaleProjectDemo.Entities;
using GameSaleProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Managers
{
    class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Item item)
        {
            Console.WriteLine(gamer.Name + " adli oyuncuya " + item.ItemName + " satisi yapildi.");
        }
    }
}
