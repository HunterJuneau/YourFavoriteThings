using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavoriteThings
{
    class Place
    {
        public ushort TimesVisited { get; set; }
        public string Address { get; set; }

        public void Visit()
        {
            TimesVisited += 1;
        }

        public void Info()
        {
            Console.WriteLine($"I have been to {Address} {TimesVisited} time(s).");
        }
    }
}
