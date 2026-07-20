using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Archetype
    {
        public string Name { get; private set; }
        public decimal BaseDamage { get; private set; }
        public decimal BaseHP { get; private set; }

        private Archetype(string name, decimal baseDamage, decimal baseHP) //Private constructor to prevent external instantiation
        {
            Name = name;
            BaseDamage = baseDamage;
            BaseHP = baseHP;
        }
        // Static properties for predefined archetypes
        public static Archetype Warrior { get; } = new Archetype("Warrior", 3, 50);
        public static Archetype Ranger { get; } = new Archetype("Ranger", 5, 30);
        public static Archetype Enemy { get; } = new Archetype("Enemy", 2, 30);
    }
}
