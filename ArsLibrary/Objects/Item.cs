using ArsLibrary.Magic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Objects
{
    public class Item
    {
        public string Name { get; set; }
        public int Load { get; set; }
        public List<Enchantment> Enchantments { get; set; }
        public bool IsOpen { get; set; }
        public int? VisCapacity { get; set; }

        public Item(string name, int load)
        {
            Name = name;
            Load = load;
            Enchantments = new List<Enchantment>();
        }
    }
}