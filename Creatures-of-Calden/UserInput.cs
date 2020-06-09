using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    static class UserInput
    {
        public static string Input()
        {
            string userInput = Console.ReadLine().ToLower();
            if (userInput == ("spellbook"))
            {
                Game.player1.PlayerSpellbook.AccessSpellbook();
            }

            return (userInput);
        }

        public static char InputKey()
        {
            char userInputKey = Console.ReadKey().KeyChar;
            if (userInputKey == 's')
            {
                Game.player1.PlayerSpellbook.AccessSpellbook();
            }
            return (userInputKey);
        }
    }
}
