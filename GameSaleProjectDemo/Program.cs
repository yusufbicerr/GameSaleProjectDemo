using GameSaleProjectDemo.Entities;
using GameSaleProjectDemo.Managers;
using System;

namespace GameSaleProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.Name = "Yusuf";
            gamer1.TcNo = "12345678900";
            gamer1.BirthDate = "04.12.2001";

            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer1);

            Item item1 = new Item()
            {
                Id = 1,
                ItemName = "Mysterious box"
            };

            SaleManager saleManager = new SaleManager();
            saleManager.Sell(gamer1,item1);

            Campaign campaign1 = new Campaign() { Id = 1,CampaignName = "Yeni kayit kampanyasi"};

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
        }
    }
}
