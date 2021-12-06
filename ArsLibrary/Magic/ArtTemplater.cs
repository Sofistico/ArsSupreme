using System.Collections.Generic;

namespace ArsLibrary.Magic
{
    public static class ArtTemplater
    {
        private static Art Corpus() => new(Form.Corpus.ToString(), 0, 0, true);

        private static Art Auram() => new(Form.Auram.ToString(), 0, 0, true);

        private static Art Aquam() => new(Form.Aquam.ToString(), 0, 0, true);

        private static Art Animal() => new(Form.Animal.ToString(), 0, 0, true);

        private static Art Herbam() => new(Form.Herbam.ToString(), 0, 0, true);

        private static Art Ignem() => new(Form.Ignem.ToString(), 0, 0, true);

        private static Art Imaginem() => new(Form.Imaginem.ToString(), 0, 0, true);

        private static Art Mentem() => new(Form.Mentem.ToString(), 0, 0, true);

        private static Art Terram() => new(Form.Terram.ToString(), 0, 0, true);

        private static Art Vim() => new(Form.Vim.ToString(), 0, 0, true);

        private static Art Creo() => new(Technique.Creo.ToString(), 0, 0, false);

        private static Art Rego() => new(Technique.Rego.ToString(), 0, 0, false);

        private static Art Muto() => new(Technique.Muto.ToString(), 0, 0, false);

        private static Art Perdo() => new(Technique.Perdo.ToString(), 0, 0, false);

        private static Art Intellego() => new(Technique.Intellego.ToString(), 0, 0, false);

        public static Art[] ListAllArts()
        {
            Art[] array = new Art[]
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
            return array;
        }
    }
}