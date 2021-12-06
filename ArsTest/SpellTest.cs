global using Range = ArsLibrary.Range;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsLibrary.Characters;
using ArsLibrary.Magic;
using NUnit.Framework;

namespace ArsTest
{
    public class SpellTest
    {
        private FormulaicSpell formSpell;
        private FormulaicSpell formSpellExtraMag;
        private SpontaneousSpell spoSpellFat;
        private SpontaneousSpell spoSpellNoFat;

        [SetUp]
        public void SetUp()
        {
            formSpell = new(Technique.Creo, Form.Auram, 5, 0, Range.Touch,
                Target.Personal, Duration.Momentany, "Test Spell");
            formSpellExtraMag = new(Technique.Creo, Form.Auram, 2, 2, Range.Touch,
                Target.Personal, Duration.Momentany, "Test Spell");
            spoSpellFat = new(Technique.Creo, Form.Auram, 5, 0, Range.Personal,
                Target.Personal, Duration.Momentany, "Test Spell", true);
            spoSpellNoFat = new(Technique.Creo, Form.Auram, 5, 0, Range.Personal,
                Target.Personal, Duration.Momentany, "Test Spell", false);
        }

        [Test]
        public void TestIfMagnitudesCorrect()
        {
            Assert.True(formSpell.Magnitude == 2 && formSpell.EffectLevel == 10);
            Assert.True(formSpellExtraMag.Magnitude == 1 && formSpellExtraMag.EffectLevel == 5);
        }
    }
}