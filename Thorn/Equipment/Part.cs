using System;
using System.Collections.Generic;

namespace Thorn.Equipment
{
    public class Part
    {
        public string Name { get; set; }
        public (int x, int y) Position { get; set; }
        public string Alignment { get; set; }
        public (int up, int right, int down, int left) SynergyDirections { get; set; }
        public object Bonus { get; set; }
        public List<object> Abilities { get; set; }
        public Dictionary<string, double> Modifiers { get; set; }

        public Part(string name)
        {
            this.Name = name;
            this.Position = (0, 0);
        }

        public Part(string name, string alignment, (int, int, int, int) synergyDirections, object bonus, List<object> abilities, Dictionary<string, double> modifiers) : this (name)
        {
            Alignment = alignment;
            SynergyDirections = synergyDirections;
            Bonus = bonus;
            Abilities = abilities;
            Modifiers = modifiers;
        }
    }
}
