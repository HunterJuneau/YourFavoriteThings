using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavoriteThings
{
    class Game
    {
        public ushort HoursPlayed { get; set; }
        public byte Rating { get; private set; }

        public void Play(byte hours)
        {
            HoursPlayed += hours;
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
