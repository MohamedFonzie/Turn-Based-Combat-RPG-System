using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Character
    {
        public string Name { get; private set; }
        private Archetype _archetype; //Composition → A Character has an Archetype

        public decimal TotalDamage
        {
            get
            {
                return _archetype.BaseDamage;
            }

        }
        public decimal MaxHP
        {
            get
            {
                return _archetype.BaseHP;
            }
        }
        public decimal CurrentHP { get; private set; }

        public Character(Archetype archetype, string name) //A Character cannot exist without an archetype or a name
        {
            _archetype = archetype;
            Name = name;
            CurrentHP = MaxHP; // Initialize CurrentHP to MaxHP when a Character is created (so it starts at full health instead of 0)
        }

        public void RestoreFullHP()
        {
            CurrentHP = MaxHP;
        }

        public void TakeDamage(decimal damageAmount) // Reduce Character's CurrentHP based on damage from anything (enemy, effects, etc...)
        {
            CurrentHP = CurrentHP - damageAmount;
            if(CurrentHP < 0)
                CurrentHP = 0; // Ensure CurrentHP doesn't go below 0
        }
    }
}
