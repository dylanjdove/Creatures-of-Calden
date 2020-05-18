using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class CharacterData
    {
        public string Class;
        public int Level;
        public string[] Equipped = new string[6];
        //create inventory array with max of 10 items
        public string[] Inventory = new string[10];

        public CharacterData()
        {
            Level = 1;
            if (Class == "wizard")
            {
                Inventory = new string[] { "spell component pouch", "spellbook", "knife", "", "", "", "", "", "", "" };
            }
            if (Class == "rogue")
            {
                Inventory = new string[] { "knife", "knife", "crossbow", "", "", "", "", "", "", "", };
            }
            if (Class == "barbarian")
            {
                Inventory = new string[] { "axe", "wooden shield", "", "", "", "", "", "", "", "", };
            }
            if (Class == "fighter")
            {
                Inventory = new string[] { "longsword", "shortsword", "rusty armor", "", "", "", "", "", "", "", };
            }
        }
    }
}
