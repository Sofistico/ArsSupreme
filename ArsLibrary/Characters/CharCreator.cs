using ArsLibrary.Magic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Characters
{
    public class CharCreator
    {
        private int maxVirtues = 10;
        private int maxFlaws = 10;
        private int characteristicsPoints = 7;
        private int virtuesPoint = 0;
        private int flawsPoint = 0;
        private int abilityXp = 0;
        private int artsXp = 0;
        private int spellXp = 0;
        private int xp = 0;
        private BaseChar character;

        public int TotalXpSpent
        {
            get { return AbilityXp + ArtsXp + SpellXp; }
        }

        public int AbilityXp
        {
            get { return abilityXp; }
        }

        public int ArtsXp
        {
            get { return artsXp; }
        }

        public int SpellXp
        {
            get { return spellXp; }
        }

        public int Xp
        {
            get { return xp - TotalXpSpent; }
        }

        public CharCreator(BaseChar baseChar)
        {
            character = baseChar;
            xp = character.TrackedXp.Xp;
            switch (character.Type)
            {
                case CharType.Grog:
                    maxVirtues = 3;
                    maxFlaws = 3;
                    break;

                default:
                    break;
            }
        }

        public void RaiseAbilityWithXp(int xpSpent, Ability ability)
        {
            if (xpSpent > xp)
                return;
            abilityXp += xpSpent;
            ability.RaiseWithXp(xpSpent);
        }

        public void RaiseArtWithXp(int xpSpent, Art art)
        {
            if (xpSpent > xp)
                return;
            artsXp += xpSpent;
            art.RaiseWithXp(xpSpent);
        }

        public void AddNewVirtue(Virtue virtue)
        {
            virtuesPoint += (int)virtue.Point;
            if (virtuesPoint < maxVirtues)
            {
                character.Virtues.Add(virtue);
            }
            else
                virtuesPoint -= (int)virtue.Point;
        }

        public void AddNewFlaw(Flaw flaw)
        {
            flawsPoint += (int)flaw.Point;

            if (flawsPoint < maxFlaws)
            {
                character.Flaws.Add(flaw);
            }
            else
                flawsPoint -= (int)flaw.Point;
        }
    }
}