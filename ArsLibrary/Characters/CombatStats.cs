using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Characters
{
    public class CombatStats
    {
        public int InnateSoak { get; set; }
        public int TotalSoak { get; set; }
        public int Encumbrence { get; set; }
        public int LTFatigue { get; set; }
        public int Fatigue { get; set; }
        public int Wounds { get; set; }
    }
}