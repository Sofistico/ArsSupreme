namespace ArsLibrary.Characters
{
    public class Flaw
    {
        public VirtuePoint Point { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Flaw(VirtuePoint virtuePoint, string name, string description)
        {
            Point = virtuePoint;
            Name = name;
            Description = description;
        }
    }
}