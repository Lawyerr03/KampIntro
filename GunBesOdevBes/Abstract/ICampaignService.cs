﻿using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Remove(Campaign campaign);
        void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}
