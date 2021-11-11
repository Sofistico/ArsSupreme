using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class FormulaicSpell : BaseHermeticMagic
    {
        public FormulaicSpell(Form form,
            Technique technique,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string description) :
            base(form, technique, baseLvl, extraMagnitude, range, target, duration, description)
        {
        }
    }
}