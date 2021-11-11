using ArsLibrary.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Objects
{
    public class Equipment : Item
    {
        public int Initiative { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }
        public Ability Ability { get; set; }
        public Range Range { get; set; }
        public Form Form { get; set; }

        public Equipment(string name,
            int load,
            int initiative,
            int attack,
            int defense,
            int damage,
            Ability ability,
            Range range,
            Form form) : base(name, load)
        {
            Initiative = initiative;
            Attack = attack;
            Defense = defense;
            Damage = damage;
            Ability = ability;
            Range = range;
            Form = form;
        }
    }
}