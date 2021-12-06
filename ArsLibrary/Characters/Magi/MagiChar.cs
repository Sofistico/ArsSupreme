using ArsLibrary.Covenants;
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
        public ArtList Arts { get; set; }

        public List<FormulaicSpell> Spells { get; set; }
        public int AppreticedAge { get; set; }
        public MagiChar? Paren { get; set; }
        public Covenant? AppreticeCovenant { get; set; }
        public Covenant? Covenant { get; set; }

        public MagiChar(string languageName) : base(languageName)
        {
            Type = CharType.Magus;
            Arts = new();
            Spells = new();
            TrackedXp.Xp = 420;
            Age = 25;
            ApparentAge = 25;
            AppreticedAge = 10;
            Virtues.Add(new Virtue(VirtuePoint.Free,
                "Hermetic Magus", "You are a wizard, harry!", VirtueType.Social));
        }
    }
}