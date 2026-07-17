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

        public Character(Archetype archetype, string name) //A Character cannot exist without an archetype or a name
        {
            _archetype = archetype;
            Name = name;
        }
    }
}
