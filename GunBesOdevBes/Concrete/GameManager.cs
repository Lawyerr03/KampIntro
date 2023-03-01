using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes.Concrete
{
    internal class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " added");
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " removed");
        }

        public void Sell(Gamer gamer, Game game)
        {
            Console.WriteLine(gamer.FirstName + " bought : " + game.GameName + " - Price : " + game.GamePrice);
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " updated");
        }


    }

   
}
