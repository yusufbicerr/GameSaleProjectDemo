using GameSaleProjectDemo.Entities;
using GameSaleProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Managers
{
    class GamerManager : IGamerService
    {
        GamerCheckManager gamerCheck = new GamerCheckManager();

        private bool _gamerCheckResponse;

        public void DeleteGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adli oyuncu silindi.");
        }

        public void Register(Gamer gamer)
        {
            _gamerCheckResponse = gamerCheck.Check(gamer);

            if (_gamerCheckResponse)
            {
                Console.WriteLine(gamer.Name + " adli oyuncu kayit oldu.");
            }
            else
            {
                Console.WriteLine("Kayit basarisiz.");
            }              
        }
        public void UpdateGamer(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + " adli oyuncu guncellendi.");
        }
    }
}
