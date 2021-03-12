using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Thorn.Equipment;

namespace ThornUnitTests.Equipment
{
    [TestClass]
    public class Part_UnitTests
    {
        [TestMethod]
        public void Part_created_with_Name_has_Name_attribute()
        {
            var testPart = new Part("Test Name");

            Assert.AreEqual(testPart.Name, "Test Name");
        }

        [TestMethod]
        public void Part_created_has_default_position_as_tuple_of_xy_00()
        {
            var testPart = new Part("Test Name");

            Assert.AreEqual(testPart.Position, (0, 0));
        }

        [TestMethod]
        public void Part_has_all_attributes_in_constructor()
        {
            var alignment = "Defense";
            var synergy = (0, 0, 1, 1);
            var bonus = new object();
            var abilities = new List<object>();
            var modifiers = new Dictionary<string, double>();

            var testPart = new Part(name: "Test Name", alignment: alignment, synergyDirections: synergy, bonus: bonus, abilities: abilities, modifiers: modifiers) ;

            Assert.AreEqual(testPart.Name, "Test Name");
            Assert.AreEqual(testPart.Alignment, alignment);
            Assert.AreEqual(testPart.SynergyDirections, synergy);
            Assert.AreEqual(testPart.Bonus, bonus);
            Assert.AreEqual(testPart.Abilities, abilities);
            Assert.AreEqual(testPart.Modifiers, modifiers);

        }
    }
}
