using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class CharacterData
    {
        public string Class;
        public SpellBook playerSpellbook { get; set; }

        public CharacterData()
        {
            Level = 1;
            if (Class == "wizard")
            {
                Inventory = new string[] { "health potion", "spellbook", };
                Equipped = new string[] { "spell component pouch", "knife", };
                Gold = 50;
                Str = 8;
                Dex = 13;
                Con = 10;
                Int = 17;
                Wis = 11;
                Cha = 10;
            }
            if (Class == "rogue")
            {
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "knife", "knife", "crossbow", };
                Str = 10;
                Dex = 17;
                Con = 10;
                Int = 11;
                Wis = 8;
                Cha = 13;
            }
            if (Class == "barbarian")
            {
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "axe", "wooden shield", };
                Str = 18;
                Dex = 11;
                Con = 17;
                Int = 10;
                Wis = 8;
                Cha = 8;
            }
            if (Class == "fighter")
            {
                Inventory = new string[] { "health potion", };
                Equipped = new string[] { "longsword", "shortsword", "rusty armor", };
                Str = 17;
                Dex = 10;
                Con = 13;
                Int = 11;
                Wis = 8;
                Cha = 10;
            }


        }

        public int AtkPower { get; private set; }
        public string SecondAttack { get; private set; }
        public int SecondAtkPower { get; private set; }
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

        //public int Attack()
        //{
        //    int attack;
        //    return attack;
        //}
    }
}
