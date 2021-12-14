using System;
using System.Collections.Generic;

namespace ArsLibrary.Magic
{
    public abstract class BaseHermeticMagic
    {
        public Form Form { get; set; }
        public Technique Technique { get; set; }
        public int Base { get; set; }
        public int Magnitude { get; private set; }
        public int ExtraMagnitude { get; set; }
        public int EffectLevel { get; set; }
        public Range Range { get; set; }
        public Target Target { get; set; }
        public Duration Duration { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public bool HasRequisite { get; set; }
        public List<Technique> TechniqueReq { get; set; }
        public List<Form> FormReq { get; set; }

        protected BaseHermeticMagic(Technique technique,
            Form form,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string name)
        {
            Form = form;
            Technique = technique;
            Base = baseLvl;
            ExtraMagnitude = extraMagnitude;
            Range = range;
            Target = target;
            Duration = duration;
            Name = name;
            TechniqueReq = new List<Technique>();
            FormReq = new List<Form>();

            CalculateMagnitudes();
        }

        private void CalculateMagnitudes()
        {
            EffectLevel = Base;
            int extraMag = ExtraMagnitude;
            int range = (int)Range;
            int dur = (int)Duration;
            int targ = (int)Target;
            extraMag += range + dur + targ;
            int i = 1;

            if (Base < 5)
            {
                for (; i <= extraMag; i++)
                {
                    if (EffectLevel == 5)
                    {
                        break;
                    }
                    EffectLevel += 1;
                }
                extraMag -= i;
            }

            EffectLevel += (extraMag * 5);

            Magnitude = EffectLevel / 5;
        }
    }
}