using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Creatures_of_Calden.Enemies
{
    class Bandit : Enemy
    {
        
        public Bandit(int health = 10) : base(health)
        {
            base.Name = "Bandit";
            base.Defense = 8;
        }

        public override void TakeDamage(int damageToTake)
        {
            base.Health -= damageToTake;
        }
        public override int DealDamage()
        {
            DieRoll roll = new DieRoll(20);
            int damageToDeal = 0;
            Console.WriteLine("The bandit swings a cudgel at you!");
            if (roll.RollDie() > Game.player1.Defense)
            {                
                damageToDeal = roll.RollDie() / 2;
                Console.WriteLine($"You have taken {damageToDeal} damage.  Health remaining:  {Game.player1.Health - damageToDeal}");
            }
            else Console.WriteLine("The bandit missed you!");
            return damageToDeal;
        }
    }
}
