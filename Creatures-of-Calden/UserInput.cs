using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class UserInput
    {
        public string Input()
        {
            string userInput = Console.ReadLine().ToLower();
            if (userInput == ("spellbook"))
            {
                Game.player1.playerSpellbook.AccessSpellbook();
            }

            return (userInput);
        }
    }
}
