using Creatures_of_Calden.CharacterInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    public class SpellBook
    {
        public Dictionary<string, Spell> Spells { get; set; }


        public SpellBook()
        {
            Spells = new Dictionary<string, Spell>();
            Spell magicBolt = new Spell(10, "Magic Bolt", "Produces a bolt of magical energy that does an automatic 10 dmg to any enemy.", true);
            Spell summonFire = new Spell(0, "Summon Fire", "Summons flame from the magic around you.  Instantly sets any flammable object on fire", false);
            Spell telekinesis = new Spell(0, "Telekinesis", "Allows you to life objects no heavier than 10 lbs from a distance of up to 30 feet.", false);
            Spells.Add("Magic Bolt", magicBolt);
            Spells.Add("Summon Fire", summonFire);
            Spells.Add("Telekinesis", telekinesis);
        }

        public void AccessSpellbook()
        {
            Console.WriteLine("Welcome to your spellbook.  In this menu, you will be able to see all your known spells and their descriptions.");

            var arr = new[]
            {
                    @"     __...--~~~~~-._   _.-~~~~~--...__ ",
                    @"   //               `V'               \\\\ ",
                    @"  //                 |                 \\\\ ",
                    @" //__...--~~~~~~-._  |  _.-~~~~~~--...__\\\\ ",
                    @"//__.....----~~~~._\\ | /_.~~~~----.....__\\\\",
                    @"===================\\\\|//====================",
                    @"                    `---`",
            };
            Console.WriteLine("\n\n");
            foreach (string line in arr) Console.WriteLine(line);
            foreach (string spell in Spells.Keys)
            {
                Console.WriteLine($"{spell}: {Spells[spell]}");
            }
            Console.ReadLine();

        }
        

        public int AttackSpell(Spell spellToUse)
        {
            int damageDealt = 0;
            Console.WriteLine("Which spell would you like to attack with?");
            if (spellToUse.IsAttackSpell)
            {
                damageDealt = spellToUse.Damage;
            }
            return damageDealt;
        }

    }
}
