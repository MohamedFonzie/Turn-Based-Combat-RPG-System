using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Player : BaseCharacter
    {
        private Archetype _archetype; //Composition → A Player has an Archetype

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
        public Player(Archetype archetype, string name) //A Character cannot exist without an archetype or a name
        {
            _archetype = archetype;
            Name = name;
            CurrentHP = MaxHP; // Initialize CurrentHP to MaxHP when a Player is created (so it starts at full health instead of 0)
        }

        public void RestoreFullHP()
        {
            CurrentHP = MaxHP;
        }
    }
}
