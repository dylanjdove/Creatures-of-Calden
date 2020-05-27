using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class SpellBook
    {
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
