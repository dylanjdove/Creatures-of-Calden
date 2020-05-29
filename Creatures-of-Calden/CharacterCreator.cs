﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden
{
    class CharacterCreator
    {

        public CharacterData CreateCharacter()
        {
            CharacterData newCharacter = new CharacterData();
            UserInput input = new UserInput();

            //create variables to hold user data
            int userAge;

            Console.WriteLine(@"|`-._/\_.-`|   _____                _                                __    _____      _     _                /\    ");
            Console.WriteLine(@"|    ||    |  / ____|              | |                              / _|  / ____|    | |   | |               ||    ");
            Console.WriteLine(@"|___o()o___| | |     _ __ ___  __ _| |_ _   _ _ __ ___  ___    ___ | |_  | |     __ _| | __| | ___ _ __      ||    ");
            Console.WriteLine(@"|__((<>))__| | |    | '__/ _ \/ _` | __| | | | '__/ _ \/ __|  / _ \|  _| | |    / _` | |/ _` |/ _ \ '_ \     ||    ");
            Console.WriteLine(@"\   o\/o   / | |____| | |  __/ (_| | |_| |_| | | |  __/\__ \ | (_) | |   | |___| (_| | | (_| |  __/ | | | ()====() ");
            Console.WriteLine(@" \        /   \_____|_|  \___|\__,_|\__|\__,_|_|  \___||___/  \___/|_|    \_____\__,_|_|\__,_|\___|_| |_|    ||    ");
            Console.WriteLine(@"  \______/                                                                                                   ()    ");
            Console.WriteLine("\n \n \n");
            
                                                                                                                                                             

            //prints opening message
            Console.WriteLine("Welcome to the world.");
            Console.WriteLine("Please input your user name.");

            //write user name to screen
            newCharacter.UserName = input.Input();
            Console.WriteLine($"Hello, {newCharacter.UserName}");

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
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            Console.WriteLine("If your health reaches 0, you will die, and the game will end.  There are a few ways you can restore health as you progress through the game");
            Console.WriteLine("Drinking a potion will restore a set amount of health based on the type of potion.  Sleeping will restore you to full health.  Some items will also restore you to full health.");
            //create a variable to hold user's class

            
            
            //determine the class the user wishes to play

            Console.WriteLine("Please choose a class for your adventure");
            Console.WriteLine("Your options are as follows:");
            Console.WriteLine("Rogue, Wizard, Barbarian, Fighter, Monk");
            newCharacter.Class = input.InputKey();


            //close application if user chooses monk
            if (newCharacter.Class == 'm')
            {
                Console.WriteLine("Rocks Fall.  Everyone Dies.");
                System.Environment.Exit(0);
                Console.ReadLine();
            }

            Console.WriteLine("You have chosen " + newCharacter.Class);

            if (newCharacter.Class == 'r')
            {
                Console.WriteLine("Rogues start with two knives and a crossbow.");
                Console.WriteLine("Rogues can wear light or medium armor.");
                Console.WriteLine("At first level, rogues can sneak attack and disengage. \n");
                Console.WriteLine("Press any key to continue.");

            }

            if (newCharacter.Class == 'w')
            {
                newCharacter.playerSpellbook = new SpellBook();
                Console.WriteLine("Wizards start with a pouch of spell components, a spellbook, and a knife.");
                Console.WriteLine("Wizards are not permitted to wear any armor per the Rialto Concord.");
                Console.WriteLine("Wizards know three basic spells at Level 1 and learn more as they progress.");
                Console.WriteLine("At Level 1, all wizards know the magic bolt, summon fire, and telekinesis spells.");
                Console.WriteLine("To access your spellbook, simply type \"s\" at any time. \n");
                Console.WriteLine("Press any key to continue.");

            }
            if (newCharacter.Class == 'b')
            {
                Console.WriteLine("Barbarians start with an axe and a wooden shield.");
                Console.WriteLine("Barbarians are tough, and thus cannot wear armor, or their family will disown them.");
                Console.WriteLine("At first level, barbarians can entle bloodlust twice a day. \n");
                Console.WriteLine("Press any key to continue.");
            }
            if (newCharacter.Class == 'f')
            {
                Console.WriteLine("Fighters start with a longsword, a shortsword, and rusty armor.");
                Console.WriteLine("Fighters can wear any armor, as long they have a sufficient strength score. \n");
                Console.WriteLine("Press any key to continue.");

            }
            else
            {
                Console.WriteLine("It looks like you mistyped.  Please Try again.");
            }






            //This will make sure the app stays open
            Console.ReadLine();
            return newCharacter;
        }


        
    }
}