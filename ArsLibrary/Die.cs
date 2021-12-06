using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary
{
    public class Die
    {
        private Random rngGod;

        public Die()
        {
            rngGod = new Random();
        }

        /// <summary>
        /// roll a ten-sided die. One
        /// and zero have special meanings, but the other
        /// numbers count for their value, as normal.On a
        /// roll of one, roll again and double the number
        /// rolled.If the re-roll is also a one, roll again and
        /// quadruple. On second and subsequent rolls, a
        /// zero counts as ten
        /// </summary>
        /// <param name="plus"></param>
        /// <param name="botches"></param>
        /// <returns>Bool returns if is a botch, int returns the value</returns>
        public (int, bool) StressDie(int plus = 0, int botches = 1)
        {
            // 0 is 10, so the roll is 0-9
            int rng = rngGod.Next(0, 10);
            // Check for botch
            if (rng == 0)
            {
                int botch = rngGod.Next(0, 10);
                if (botch != 0)
                {
                    return (rng + plus, false);
                }
                else if (botch == 0)
                {
                    int fuckedNumber = 0;
                    for (int i = 0; i < botches; i++)
                    {
                        fuckedNumber += rngGod.Next(0, 10);
                    }
                    return (fuckedNumber, true);
                }
            }
            if (rng == 1)
            {
                int explosion;
                int multiplication = 2;
                do
                {
                    explosion = rngGod.Next(0, 10);
                    if (explosion == 1)
                    {
                        multiplication *= 2;
                    }
                    if (explosion == 0)
                    {
                        explosion = 10;
                    }
                } while (explosion == 1);
                int roll = explosion * multiplication;
                return (roll + plus, false);
            }
            return (rng + plus, false);
        }

        /// <summary>
        /// Roll a ten-sided die. Each number counts
        /// for its value, except that a zero counts as ten.
        /// </summary>
        /// <param name="plus"></param>
        public int SimpleDie(int plus = 0)
        {
            return rngGod.Next(0, 10) + plus;
        }
    }
}