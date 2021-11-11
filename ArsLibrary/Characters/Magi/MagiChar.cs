using ArsLibrary.Magic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Characters.Magi
{
    public class MagiChar : BaseChar
    {
        public List<Art> Arts { get; set; }
        public List<FormulaicSpell> Spells { get; set; }

        public MagiChar(string languageName) : base(languageName)
        {
            Type = CharType.Magus;
            Arts = ArtDictionary.ListAllArts();
            Spells = new();
            TrackedXp.Xp = 420;
            Age = 25;
            ApparentAge = 25;
            Virtues.Add(new Virtue(VirtuePoint.Free, "Magus", "You are a wizard, harry!"));
        }
    }
}