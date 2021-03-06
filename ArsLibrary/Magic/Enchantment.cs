using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class Enchantment : BaseHermeticMagic
    {
        public Enchantment(Technique technique,
            Form form,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string description) :
            base(technique, form, baseLvl, extraMagnitude, range, target, duration, description)
        {
        }
    }
}