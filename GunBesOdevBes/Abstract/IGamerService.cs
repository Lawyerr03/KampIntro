using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Remove(Gamer gamer);
    }
}
