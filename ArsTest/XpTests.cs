global using ArsLibrary;
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
    public class XpTests
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        private Art art;
        private Ability ability;
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.

        [SetUp]
        public void SetUp()
        {
            art = new(Form.Vim.ToString(), 0, 0, true);
            ability = new("Magic Lore", AbilityType.Academic, 1);
        }

        [Test]
        public void RaiseXpArt()
        {
            art.RaiseWithXp(1);

            Assert.True(art.Level == 1);

            art.RaiseWithXp(4);

            Assert.True(art.Level == 2);

            art.RaiseWithXp(1);

            Assert.True(art.Level == 3);
        }

        [Test]
        public void BuyWithXpArt()
        {
            art.RaiseWithXp(55);
            Assert.True(art.Level == 10);
        }

        [Test]
        public void RaiseXpAbility()
        {
            ability.RaiseWithXp(6);

            Assert.True(ability.Level == 1);

            ability.RaiseWithXp(9);

            Assert.True(ability.Level == 2);
        }

        [Test]
        public void BuyXpAbility()
        {
            ability.RaiseWithXp(275);

            Assert.True(ability.Level == 10);
        }
    }
}