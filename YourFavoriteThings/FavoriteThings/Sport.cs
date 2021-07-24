using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourFavoriteThings.FavoriteThings
{
    class Sport
    {
        public ushort TimesPlayed { get; set; }
        public byte Skill { get; private set; }

        public void Play()
        {
            TimesPlayed += 1;
        }

        public void SetSkill(byte skill)
        {
            if (skill <= 10)
            {
                Skill = skill;
            }
        }
    }
}
