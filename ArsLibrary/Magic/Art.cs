using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class Art
    {
        private bool recursive = false;

        public int CurrentXp { get; set; }
        public int Level { get; set; }
        public string ArtName { get; set; }
        public bool IsForm { get; private set; }
        public int XpSpent { get; private set; }
        public int ReminderXp { get; private set; }

        public Art(string artName, int level, int currentXp, bool isForm)
        {
            ArtName = artName;
            Level = level;
            CurrentXp = currentXp;
            IsForm = isForm;
        }

        public void RaiseWithXp(int xpSpent)
        {
            if (!recursive)
                XpSpent += xpSpent;

            int xpNeeded = Level + 1;

            if (xpSpent + ReminderXp >= xpNeeded)
            {
                xpSpent = (xpSpent + ReminderXp) - xpNeeded;
                Level++;

                if (xpSpent != 0 && xpSpent < (Level + 1))
                {
                    ReminderXp = xpSpent;
                    xpSpent = 0;
                }
                else
                    ReminderXp = 0;

                if (xpSpent + ReminderXp >= (Level + 1))
                {
                    recursive = true;

                    RaiseWithXp(xpSpent);
                }
            }
            recursive = false;

        }
    }
}