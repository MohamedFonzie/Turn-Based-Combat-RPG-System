using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Enemy : BaseCharacter
    {
        public decimal TotalDamage { get; private set; }
        public decimal MaxHP { get; private set; }

        public Enemy(string name)
        {
            Name = name;
            TotalDamage = 2; // Example damage value
            MaxHP = 30; // Example HP value
            CurrentHP = MaxHP; // Initialize CurrentHP to MaxHP when an Enemy is created (so it starts at full health instead of 0)
        }

        public void RestoreFullHP()
        {
            CurrentHP = MaxHP;
        }
    }
}
