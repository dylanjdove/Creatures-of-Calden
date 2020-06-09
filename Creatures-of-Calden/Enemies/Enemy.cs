using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden.Enemies
{
    public abstract class Enemy
    {
        public int Health { get; protected set; }
        public string Name { get; protected set; }
        public int Defense { get; protected set; }

        public Enemy(int health)
        {
            Health = health;
        }

        public abstract void TakeDamage(int damageToTake);

        public abstract int DealDamage();

    }
}
