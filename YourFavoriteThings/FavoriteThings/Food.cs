using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavoriteThings
{
    class Food
    {
        public ushort TimesEaten { get; set; }
        public byte Rating { get; private set; }

        public void Eat()
        {
            TimesEaten += 1;
        }

        public void Rate(byte rating)
        {
            if (rating <= 10)
            {
                Rating = rating;
            }
        }
    }
}
