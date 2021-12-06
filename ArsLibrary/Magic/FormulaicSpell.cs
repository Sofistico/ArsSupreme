using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class FormulaicSpell : BaseHermeticMagic
    {
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
        }
    }
}