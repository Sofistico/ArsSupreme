using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class FormulaicSpell : BaseHermeticMagic
    {
        public int MasteryLevel { get; set; }
        public int TotalXp { get; set; }
        public List<MasteryAbility> MasteryAbility { get; set; }

        public FormulaicSpell(Technique technique,
            Form form,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string name) :
            base(technique, form, baseLvl, extraMagnitude, range, target, duration, name)
        {
            MasteryAbility = new List<MasteryAbility>();
        }
    }

    public enum MasteryAbility
    {
        Penetration
    }
}