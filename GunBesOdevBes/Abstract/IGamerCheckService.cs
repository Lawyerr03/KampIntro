using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes.Abstract
{
    internal interface IGamerCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
