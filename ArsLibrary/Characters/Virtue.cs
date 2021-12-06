namespace ArsLibrary.Characters
{
    public class Virtue
    {
        public VirtuePoint Point { get; set; }
        public VirtueType Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Virtue(VirtuePoint virtuePoint, string name, string description, VirtueType virtueType)
        {
            Point = virtuePoint;
            Name = name;
            Description = description;
            Type = virtueType;
        }
    }

    public enum VirtuePoint
    {
        Free = 0,
        Minor = 1,
        Major = 3
    }

    public enum VirtueType
    {
        General,
        Hermetic,
        Supernatural,
        Social,
        Personality,
        Special,
        Story
    }
}