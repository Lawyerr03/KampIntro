using GunBesOdevBes.Abstract;
using GunBesOdevBes.Adaptors;
using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
