using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class SpontaneousSpell : BaseHermeticMagic
    {
        public bool IsFatiguing { get; set; }

        public SpontaneousSpell(Technique technique,
            Form form,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string name,
            bool isFatiguing) :
            base(technique, form, baseLvl, extraMagnitude, range, target, duration, name)
        {
            IsFatiguing = isFatiguing;
        }
    }
}