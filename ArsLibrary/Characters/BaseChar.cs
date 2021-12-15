using ArsLibrary.Characters.Advancement;
using ArsLibrary.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Characters
{
    public abstract class BaseChar
    {
        public Stats Stats { get; set; }
        public TrackXp TrackedXp { get; set; }
        public List<Virtue> Virtues { get; set; }
        public List<Flaw> Flaws { get; set; }
        public List<Ability> Abilities { get; set; }
        public Ability NativeLanguage { get; set; }
        public List<PersonalityTrait> PersonalitiesTraits { get; set; }
        public List<Reputation> Reputations { get; set; }
        public CombatStats CombatStats { get; set; }
        public int Confidence { get; set; }
        public int MaxConfidence { get; set; }

        public int Age { get; set; }
        public int ApparentAge { get; set; }
        public int Decrepitude { get; set; }
        public int Warping { get; set; }
        public List<Equipment> Equipment { get; set; }
        public List<Item> Inventory { get; set; }

        public CharType Type { get; set; }

        public BaseChar(string languageName)
        {
            Stats = new();
            Virtues = new();
            Flaws = new();
            TrackedXp = new TrackXp();
            Abilities = new List<Ability>();
            PersonalitiesTraits = new();
            Reputations = new List<Reputation>();
            CombatStats = new CombatStats();
            Inventory = new();
            Equipment = new List<Equipment>();
            NativeLanguage = new(languageName, AbilityType.General, 0)
            {
                Level = 5
            };
            Abilities.Add(NativeLanguage);
        }

        public void AddNewAbility(Ability ability)
        {
            Abilities.Add(ability);
        }

        public void AddNewAbilityWithXp(Ability ability, int xpSpent)
        {
            if (xpSpent > TrackedXp.Xp)
                return;
            TrackedXp.Xp -= xpSpent;
            TrackedXp.SpentXp += xpSpent;
            ability.RaiseWithXp(xpSpent);
            AddNewAbility(ability);
        }
    }

    public enum CharType
    {
        Grog,
        Creature,
        Companion,
        Magus,
    }
}