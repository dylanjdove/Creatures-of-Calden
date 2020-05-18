using Creatures_of_Calden;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        public static void Game()
        {

            //create variables to hold user data
            string userName;
            int userAge;

            //prints opening message
            Console.WriteLine("Welcome to the world.");
            Console.WriteLine("Please input your user name.");

            //write user name to screen
            userName = UserInput();
            Console.WriteLine("Hello, " + userName);

            //obtains user age
            Console.WriteLine("Please input your age.");
            userAge = int.Parse(UserInput());

            //closes the app if user is underage.
            if (userAge < 18)
            {
                System.Environment.Exit(0);
            }

            //introduces the user to the world
            Console.WriteLine("We're glad to see that you meet our age requirements.  Prepare to be immersed in a world of danger and violence.");
            Console.WriteLine("In the world of Calden, there are many dangerous creatures.  Many of them will be too strong for you to defeat early on.");

            //create a variable to hold user's class

            CharacterData newCharacter = new CharacterData();
            //determine the class the user wishes to play

            Console.WriteLine("Please choose a class for your adventure");
            Console.WriteLine("Your options are as follows:");
            Console.WriteLine("Rogue, Wizard, Barbarian, Fighter, Monk");
            newCharacter.Class = UserInput();
            

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
        }

        public static void SpellBook()
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
        public static string UserInput()
        {
            string userInput = Console.ReadLine().ToLower();
            if (userInput == ("spellbook"))
            {
                SpellBook();
            }

            return (userInput);
        }
    }
}
