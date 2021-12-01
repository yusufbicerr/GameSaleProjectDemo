using GameSaleProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProjectDemo.Interfaces
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
    }
}
