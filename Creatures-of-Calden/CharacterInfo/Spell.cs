using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Creatures_of_Calden.CharacterInfo
{
    public class Spell
    {
        public int Damage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsAttackSpell { get; set; }
        public Spell (int damage, string name, string description, bool isAttack)
        {
            Damage = damage;
            Name = name;
            Description = description;
            IsAttackSpell = isAttack;
        }
    }
}
