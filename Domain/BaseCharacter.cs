using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BaseCharacter
    {
        public string Name { get; protected set; }
        public decimal CurrentHP { get; protected set; }

        public void TakeDamage(decimal damageAmount) // Reduce Character's CurrentHP based on damage from anything (enemy, effects, etc...)
        {
            CurrentHP = CurrentHP - damageAmount;
            if (CurrentHP < 0)
                CurrentHP = 0; // Ensure CurrentHP doesn't go below 0
        }
    }
}
