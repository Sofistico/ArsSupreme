using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Characters
{
    public class Stats
    {
        public int Intelligence { get; set; }
        public int Presence { get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Perception { get; set; }
        public int Comunication { get; set; }
        public int Stamina { get; set; }
        public int Quickness { get; set; }
        public int Size { get; set; }

        public Stats()
        {
        }

        public Stats(int intelligence,
            int presence,
            int strenght,
            int dexterity,
            int perception,
            int comunication,
            int stamina,
            int quickness)
        {
            Intelligence = intelligence;
            Presence = presence;
            Strenght = strenght;
            Dexterity = dexterity;
            Perception = perception;
            Comunication = comunication;
            Stamina = stamina;
            Quickness = quickness;
        }
    }
}