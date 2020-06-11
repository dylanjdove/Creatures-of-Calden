using System;
using System.Collections.Generic;
using System.Text;
using Creatures_of_Calden.Enemies;

namespace Creatures_of_Calden
{
    public class CharacterData
    {
        public string Class { get; set; }
        public SpellBook PlayerSpellbook { get; set; }
        public string UserName { get; set; }
        public int Health { get; set; }

        public CharacterData(string userClass)
        {
            Level = 1;
            if (userClass == "wizard")
            {
                PlayerSpellbook = new SpellBook();
                Class = "wizard";
                Health = 20;
                Inventory = new string[] { "health potion", "spellbook", };
                Equipped = new string[] { "spell component pouch", "knife", };
                Gold = 50;
                Defense = 10;
                AtkPower = 2;
                Str = -2;
                Dex = 1;
                Con = 0;
                Int = 3;
                Wis = 0;
                Cha = 0;
            }
            if (userClass == "rogue")
            {
                Class = "rogue";
                Health = 30;
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "knife", "knife", "crossbow", };
                Gold = 50;
                AtkPower = 2;
                Defense = 10;
                Str = 0;
                Dex = 3;
                Con = 0;
                Int = 0;
                Wis = -2;
                Cha = 1;
            }
            if (userClass == "barbarian")
            {
                Class = "barbarian";
                Health = 40;
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "axe", "wooden shield", };
                Gold = 50;
                AtkPower = 3;
                Defense = 15;
                Str = 4;
                Dex = 1;
                Con = 3;
                Int = 0;
                Wis = -2;
                Cha = -2;
            }
            if (userClass == "fighter")
            {
                Class = "fighter";
                Health = 40;
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "longsword", "shortsword", "rusty armor", };
                Gold = 50;
                AtkPower = 2;
                SecondAtkPower = 1;
                Defense = 12;
                Str = 3;
                Dex = 0;
                Con = 1;
                Int = 0;
                Wis = -2;
                Cha = 0;
            }


        }

        public int AtkPower { get; private set; }
        public string SecondAttack { get; private set; }
        public int SecondAtkPower { get; private set; }
        public int Defense { get; private set; }
        public int Str { get; private set; }
        public int Dex { get; private set; }
        public int Con { get; private set; }
        public int Int { get; private set; }
        public int Wis { get; private set; }
        public int Cha { get; private set; }
        public int Level { get; private set; }
        public string[] Equipped { get; private set; } = new string[7];
        //create inventory array with max of 10 items
        public string[] Inventory = new string[10];
        public int Gold { get; private set; }

        public bool StealthCheck()
        {
            //roll a d20 to determing if the user successfully hides or sneaks
            bool successfulCheck = false;
            DieRoll stealth = new DieRoll(20);
            int rollNumber = stealth.RollDie() + this.Dex;
            if(rollNumber >= 13)
            {
                successfulCheck = true;
            }
            return successfulCheck;
        }

        public void TakeDamage(int damageToTake)
        {
            Health -= damageToTake;
        }

        public void DealDamage(Enemy targetEnemy)
        {
            DieRoll d20 = new DieRoll(20);
            DieRoll d12 = new DieRoll(12);
            DieRoll d10 = new DieRoll(10);
            DieRoll d8 = new DieRoll(8);
            int damageDealt = 0;
            string successfulHitMessage = $"You successfully hit the {targetEnemy.Name}.";
            string damageDealtMessage = "Damage Dealt: ";
            string failedHitMessage = $"You miss the {targetEnemy.Name}.";
            string killMessage = $"You have slain the {targetEnemy.Name}.";

            if (Class == "fighter")
            {
                Console.WriteLine($"You swing your longsword at the {targetEnemy.Name}");
                int d20Roll = d20.RollDie();
                if(d20Roll + this.Str > targetEnemy.Defense)
                {
                    damageDealt = d10.RollDie() + this.AtkPower;
                    Console.WriteLine($"{successfulHitMessage}  {damageDealtMessage} {damageDealt}.");
                    targetEnemy.TakeDamage(damageDealt);
                }
                else
                {
                    Console.WriteLine(failedHitMessage);
                }
                Console.WriteLine($"You swing your shortsword at the {targetEnemy.Name}");
                d20Roll = d20.RollDie();
                if(d20Roll + this.Str > targetEnemy.Defense)
                {
                    damageDealt = d8.RollDie() + this.SecondAtkPower;
                    Console.WriteLine($"{successfulHitMessage}  {damageDealtMessage} {damageDealt}.");
                    targetEnemy.TakeDamage(damageDealt);
                }
                else
                {
                    Console.WriteLine(failedHitMessage);
                }
                if (targetEnemy.Health <= 0)
                {
                    Console.WriteLine(killMessage);
                }
            }
            else if (Class == "barbarian")
            {
                Console.WriteLine($"You swing your axe at the {targetEnemy.Name}");
                int d20Roll = d20.RollDie();
                if (d20Roll + this.Str > targetEnemy.Defense)
                {
                    damageDealt = d12.RollDie() + this.AtkPower;
                    Console.WriteLine($"{successfulHitMessage}  {damageDealtMessage} {damageDealt}.");
                    targetEnemy.TakeDamage(damageDealt);
                }
                else
                {
                    Console.WriteLine(failedHitMessage);
                }                
                if (targetEnemy.Health <= 0)
                {
                    Console.WriteLine(killMessage);
                }
            }
            else if (Class == "wizard")
            {
                Console.WriteLine("Would you like to use a spell? (y/n)");
                char yesOrNo = UserInput.InputKey();
                if(yesOrNo == 'y')
                {
                    bool choseSpell = false;
                    while (!choseSpell)
                    {
                        Console.WriteLine("Type the name of the spell you'd like to use or \"s\" to access your spellbook.");
                        string chosenSpell = UserInput.Input();
                        if (chosenSpell == "s")
                        {
                            Game.player1.PlayerSpellbook.AccessSpellbook();
                        }
                        else if (Game.player1.PlayerSpellbook.Spells[chosenSpell].IsAttackSpell)
                        {
                            int damage = Game.player1.PlayerSpellbook.AttackSpell(Game.player1.PlayerSpellbook.Spells[chosenSpell]);
                            choseSpell = true;
                            int d20Roll = d20.RollDie();
                            if (d20Roll + this.Int > targetEnemy.Defense)
                            {
                                damageDealt = damage + this.AtkPower;
                                Console.WriteLine($"{successfulHitMessage}  {damageDealtMessage} {damageDealt}.");
                                targetEnemy.TakeDamage(damageDealt);
                            }
                            else
                            {
                                Console.WriteLine(failedHitMessage);
                            }
                            if (targetEnemy.Health <= 0)
                            {
                                Console.WriteLine(killMessage);
                            }
                        }
                        else Console.WriteLine("It seems you've chosen a non-attack spell.  Please choose a different spell.");
                    }
                    
                }
            }
        }
    }
}
