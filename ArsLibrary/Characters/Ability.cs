using System;

namespace ArsLibrary.Characters
{
    public class Ability
    {
        private bool recursive = false;
        public int Id { get; internal set; }
        public AbilityType AbilityType { get; internal set; }
        public string Name { get; internal set; }
        public int Level { get; internal set; }
        public int SpentXp { get; private set; }
        public int RemainderXp { get; private set; }

        public Ability(string name, AbilityType abilityType, int id)
        {
            Name = name;
            AbilityType = abilityType;
            Id = id;
        }

        public void RaiseWithXp(int xpSpent)
        {
            if (!recursive)
                SpentXp += xpSpent;

            int xpNeeded = Level == 0 ? 5 : (Level + 1) * 5;

            if (xpSpent + RemainderXp >= xpNeeded)
            {
                xpSpent = (xpSpent + RemainderXp) - xpNeeded;
                Level++;

                if (xpSpent != 0 && xpSpent < ((Level + 1) * 5))
                    RemainderXp = xpSpent;

                if (xpSpent % 5 == 0)
                {
                    recursive = true;
                    if (xpSpent == 0)
                    {
                        RemainderXp = 0;
                    }
                    else
                        RaiseWithXp(xpSpent);
                }
            }
            recursive = false;

        }
    }

    public enum AbilityType
    {
        General,
        Academic
    }
}