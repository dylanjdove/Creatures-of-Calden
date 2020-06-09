using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    public class SpellBook
    {
        public Dictionary<string, string> Spells { get; set; } = new Dictionary<string, string>();


        public SpellBook()
        {
            Spells.Add("Magic Bolt", "Produces a bolt of magical energy that does an automatic 3 dmg to any enemy.");
            Spells.Add("Summon Fire", "Summons flame from the magic around you.  Instantly sets any flammable object on fire");
            Spells.Add("Telekinesis", "Allows you to life objects no heavier than 10 lbs from a distance of up to 30 feet.");
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
            Console.ReadLine();

        }

    }
}
