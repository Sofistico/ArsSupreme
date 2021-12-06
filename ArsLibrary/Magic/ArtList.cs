using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsLibrary.Magic
{
    public class ArtList
    {
        private Art[] arts = ArtTemplater.ListAllArts();

        public Art this[string name] => arts.FirstOrDefault(a => a.ArtName == name);
        public Art this[int index] => arts[index];
    }
}