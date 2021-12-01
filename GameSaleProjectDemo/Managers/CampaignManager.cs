using GameSaleProjectDemo.Entities;
using GameSaleProjectDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Managers
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adli kampanya eklendi.");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adli kampanya silindi.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " adli kampanya güncellendi.");
        }
    }
}
