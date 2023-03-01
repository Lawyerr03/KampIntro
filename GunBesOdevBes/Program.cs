using GunBesOdevBes.Abstract;
using GunBesOdevBes.Adaptors;
using GunBesOdevBes.Concrete;
using GunBesOdevBes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunBesOdevBes
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Gamer> gamers = new List<Gamer>();
            List<Campaign> campaigns = new List<Campaign>();
            List<Game> games = new List<Game>();

            gamers.Add(new Gamer { FirstName = "Muhammed Mustafa", LastName = "ÇELİK", DateOfBirth = new DateTime(1995, 7, 15), TcNo = "13753437924", Id = 1 });

            GamerManager gamerManager = new GamerManager(new EdevletServiceAdaptor());
            
            foreach (var item in gamers)
            {
                gamerManager.Add(item);
            }

            games.Add(new Game { GameName = "DOTA 2", GamePrice = 300, Id = 1 });

            GameManager gameManager = new GameManager();
            
            foreach (var item in games)
            {
                gameManager.Add(item);
            }

            campaigns.Add(new Campaign { Id = 1, Name = "Winter Sale", Deadline = new DateTime(2023, 3, 1), DiscountRate = 30 });

            CampaignManager campaignManager = new CampaignManager();
            
            foreach (var item in campaigns)
            {
                campaignManager.Add(item);
            }


            campaignManager.Sell(gamers[0], games[0], campaigns[0]);

            Console.ReadKey();
        }
    }
}