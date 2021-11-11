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

        protected BaseHermeticMagic(Form form,
            Technique technique,
            int baseLvl,
            int extraMagnitude,
            Range range,
            Target target,
            Duration duration,
            string description)
        {
            Form = form;
            Technique = technique;
            Base = baseLvl;
            ExtraMagnitude = extraMagnitude;
            Range = range;
            Target = target;
            Duration = duration;
            Description = description;
        }
    }
}