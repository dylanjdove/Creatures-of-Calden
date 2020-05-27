using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class CharacterCreator
    {

        public CharacterData CreateCharacter()
        {
            UserInput input = new UserInput();

            //create variables to hold user data
            string userName;
            int userAge;

            //prints opening message
            Console.WriteLine("Welcome to the world.");
            Console.WriteLine("Please input your user name.");

            //write user name to screen
            userName = input.Input();
            Console.WriteLine("Hello, " + userName);

            //obtains user age
            Console.WriteLine("Please input your age.");
            userAge = int.Parse(input.Input());

            //closes the app if user is underage.
            if (userAge < 18)
            {
                System.Environment.Exit(0);
            }

            //introduces the user to the world
            Console.WriteLine("We're glad to see that you meet our age requirements.  Prepare to be immersed in a world of danger and violence.");
            Console.WriteLine("In the world of Calden, there are many dangerous creatures.  Many of them will be too strong for you to defeat early on.");
            Console.WriteLine("Throughout this game, you will be presented with 3 choices in any given situation.  The type of choices will vary based on the situation");
            Console.ReadLine();
            Console.WriteLine("If your health reaches 0, you will die, and the game will end.  There are a few ways you can restore health as you progress through the game");
            Console.WriteLine("Drinking a potion will restore a set amount of health based on the type of potion.  Sleeping will restore you to full health.  Some items will also restore you to full health.");
            //create a variable to hold user's class

            CharacterData newCharacter = new CharacterData();
            //determine the class the user wishes to play

            Console.WriteLine("Please choose a class for your adventure");
            Console.WriteLine("Your options are as follows:");
            Console.WriteLine("Rogue, Wizard, Barbarian, Fighter, Monk");
            newCharacter.Class = input.Input();


            //close application if user chooses monk
            if (newCharacter.Class == "monk")
            {
                Console.WriteLine("Rocks Fall.  Everyone Dies.");
                System.Environment.Exit(0);
                Console.ReadLine();
            }

            Console.WriteLine("You have chosen " + newCharacter.Class);

            if (newCharacter.Class == "rogue")
            {
                Console.WriteLine("Rogues start with two knives and a crossbow.");
                Console.WriteLine("Rogues can wear light or medium armor.");
                Console.WriteLine("At first level, rogues can sneak attack and disengage. \n");
            }

            if (newCharacter.Class == "wizard")
            {
                newCharacter.playerSpellbook = new SpellBook();
                Console.WriteLine("Wizards start with a pouch of spell components, a spellbook, and a knife.");
                Console.WriteLine("Wizards are not permitted to wear any armor per the Rialto Concord.");
                Console.WriteLine("Wizards know three basic spells at Level 1 and learn more as they progress.");
                Console.WriteLine("At Level 1, all wizards know the magic bolt, summon fire, and telekinesis spells.");
                Console.WriteLine("To access your spellbook, simply type \"spellbook\" at any time. \n");

            }
            if (newCharacter.Class == "barbarian")
            {
                Console.WriteLine("Barbarians start with an axe and a wooden shield.");
                Console.WriteLine("Barbarians are tough, and thus cannot wear armor, or their family will disown them.");
                Console.WriteLine("At first level, barbarians can entle bloodlust twice a day. \n");
            }
            if (newCharacter.Class == "fighter")
            {
                Console.WriteLine("Fighters start with a longsword, a shortsword, and rusty armor.");
                Console.WriteLine("Fighters can wear any armor, as long they have a sufficient strength score. \n");

            }

            Console.WriteLine("You find yourself awakening in an unfamiliar location.  You're in what appears to be a once-fine tavern that has gone to disrepair.  There are no patrons, and the fire is unlit. \n");
            Console.WriteLine("You are sitting hunched over in a corner table, with a decent view of the entire room.  You can see that the door is hanging off it's hinges and there's no propieter in sight. \n");
            Console.WriteLine("The whole room appears to be covered in a substantial layer of dust.  Oddly, you have what appears to be a clean glass full of ale on the table in front of you. \n");
            Console.WriteLine("In this game, you will be presented with 3 options for each action you may take.  Remember to choose wisely.");
            Console.WriteLine("You have three options you may take:  drink from the glass, ignore the glass, or inspect the glass.");




            //This will make sure the app stays open
            Console.ReadLine();
            return newCharacter;
        }


        
    }
}
