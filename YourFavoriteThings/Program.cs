using YourFavoriteThings.FavoriteThings;
using System;

namespace YourFavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var ClamChowder = new Food
            {
                TimesEaten = 25
            };
            ClamChowder.Eat();
            ClamChowder.Rate(9);
            Console.WriteLine("-- CLAM CHOWDER --");
            Console.WriteLine($"Rating: {ClamChowder.Rating}/10");
            Console.WriteLine($"Eaten {ClamChowder.TimesEaten} time(s).");

            var Calamari = new Food
            {
                TimesEaten = 1
            };
            Calamari.Eat();
            Calamari.Rate(6);
            Console.WriteLine("-- CALAMARI --");
            Console.WriteLine($"Rating: {Calamari.Rating}/10");
            Console.WriteLine($"Eaten {Calamari.TimesEaten} time(s).");


            var RocketLeague = new Game
            {
                HoursPlayed = 1_052
            };
            RocketLeague.Play(2);
            RocketLeague.Rate(9);
            Console.WriteLine("-- ROCKET LEAGUE --");
            Console.WriteLine($"Rating: {RocketLeague.Rating}/10");
            Console.WriteLine($"Played for {RocketLeague.HoursPlayed} hour(s).");


            var WarThunder = new Game
            {
                HoursPlayed = 409
            };
            WarThunder.Play(2);
            WarThunder.Rate(6);
            Console.WriteLine("-- WAR THUNDER --");
            Console.WriteLine($"Rating: {WarThunder.Rating}/10");
            Console.WriteLine($"Played for {WarThunder.HoursPlayed} hour(s).");


            var HolidayWorld = new Place
            {
                TimesVisited = 5,
                Address = "452 E Christmas Blvd, Santa Claus, IN 47579"
            };
            HolidayWorld.Visit();
            Console.WriteLine("-- HOLIDAY WORLD --");
            HolidayWorld.Info();

            var NashvilleShores = new Place
            {
                TimesVisited = 1,
                Address = "4001 Bell Rd, Nashville, TN 37076"
            };
            NashvilleShores.Visit();
            Console.WriteLine("-- NASHVILLE SHORES --");
            NashvilleShores.Info();


            var Soccer = new Sport
            {
                TimesPlayed = 12
            };
            Soccer.Play();
            Soccer.SetSkill(3);
            Console.WriteLine("-- SOCCER --");
            Console.WriteLine($"I have played {Soccer.TimesPlayed} time(s).");
            Console.WriteLine($"Skill: {Soccer.Skill}/10");

            var Football = new Sport
            {
                TimesPlayed = 0
            };
            Football.Play();
            Football.SetSkill(2);
            Console.WriteLine("-- FOOTBALL --");
            Console.WriteLine($"I have played {Football.TimesPlayed} time(s).");
            Console.WriteLine($"Skill: {Football.Skill}/10");
        }
    }
}
