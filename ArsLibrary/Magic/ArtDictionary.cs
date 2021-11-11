using System.Collections.Generic;

namespace ArsLibrary.Magic
{
    public static class ArtDictionary
    {
        public static Art Corpus() => new(Form.Corpus.ToString(), 0, 0, true);

        public static Art Auram() => new(Form.Auram.ToString(), 0, 0, true);

        public static Art Aquam() => new(Form.Aquam.ToString(), 0, 0, true);

        public static Art Animal() => new(Form.Animal.ToString(), 0, 0, true);

        public static Art Herbam() => new(Form.Herbam.ToString(), 0, 0, true);

        public static Art Ignem() => new(Form.Ignem.ToString(), 0, 0, true);

        public static Art Imaginem() => new(Form.Imaginem.ToString(), 0, 0, true);

        public static Art Mentem() => new(Form.Mentem.ToString(), 0, 0, true);

        public static Art Terram() => new(Form.Terram.ToString(), 0, 0, true);

        public static Art Vim() => new(Form.Vim.ToString(), 0, 0, true);

        public static Art Creo() => new(Technique.Creo.ToString(), 0, 0, false);

        public static Art Rego() => new(Technique.Rego.ToString(), 0, 0, false);

        public static Art Muto() => new(Technique.Muto.ToString(), 0, 0, false);

        public static Art Perdo() => new(Technique.Perdo.ToString(), 0, 0, false);

        public static Art Intellego() => new(Technique.Intellego.ToString(), 0, 0, false);

        public static List<Art> ListAllArts()
        {
            List<Art> list = new List<Art>()
            {
                Corpus(),
                Auram(),
                Aquam(),
                Animal(),
                Herbam(),
                Ignem(),
                Imaginem(),
                Mentem(),
                Terram(),
                Vim(),
                Creo(),
                Rego(),
                Muto(),
                Perdo(),
                Intellego(),
            };
            return list;
        }
    }
}