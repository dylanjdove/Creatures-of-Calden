using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class CharacterData
    {
        public string Class;
        public int Level;
        //create inventory array with max of 10 items
        public string[] Inventory = new string[10];

        public CharacterData()
        {
            Level = 1;
            if (Class == "wizard")
            {
                Inventory = new string[] { "spell component pouch", "spellbook", "knife", "", "", "", "", "", "", "" };
            }
        }
    }
}
