using System;
using System.Collections.Generic;
using System.Linq;
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

            string spellBook = "spellbook";

            //prints opening message
            Console.WriteLine("Welcome to the world.");
            Console.WriteLine("Please input your user name.");

            //write user name to screen
            userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);

            //obtains user age
            Console.WriteLine("Please input your age.");
            userAge = int.Parse(Console.ReadLine());

            //closes the app if user is underage.
            if (userAge < 18)
            {
                System.Environment.Exit(0);
            }

            //introduces the user to the world
            Console.WriteLine("We're glad to see that you meet our age requirements.  Prepare to be immersed in a world of danger and violence.");
            Console.WriteLine("In the world of Calden, there are many dangerous creatures.  Many of them will be too strong for you to defeat early on.");

            //create a variable to hold user's class
            string userClass;

            //determine the class the user wishes to play

            Console.WriteLine("Please choose a class for your adventure");
            Console.WriteLine("Your options are as follows:");
            Console.WriteLine("Rogue, Wizard, Barbarian, Fighter, Monk");
            userClass = Console.ReadLine().ToLower();

            //close application if user chooses monk
            if (userClass == "monk")
            {
                Console.WriteLine("Rocks Fall.  Everyone Dies.");
                System.Environment.Exit(0);
            }

            Console.WriteLine("You have chosen " + userClass);
           
            if (userClass == "rogue")
            {
                Console.WriteLine("Rogues start with two knives and a crossbow.");
                Console.WriteLine("Rogues can wear light or medium armor.");
                Console.WriteLine("At first level, rogues can sneak attack and disengage.");
            }

            if (userClass == "wizard")
            {
                Console.WriteLine("Wizards start with a pouch of spell components and a knife.");
                Console.WriteLine("Wizards are not permitted to wear any armor per the Rialto Concord.");
                Console.WriteLine("Wizards know three basic spells at first level and learn more as they progress.");
                Console.WriteLine("At first level, all wizards know the magic bolt, summon fire, and telekinesis spells.");
                Console.WriteLine("To access your spellbook, simply type \"spellbook\" at any time.");

            }
            if (userClass == "barbarian")
            {
                Console.WriteLine("Barbarians start with an axe and a wooden shield.");
                Console.WriteLine("Barbarians are tough, and thus cannot wear armor, or their family will disown them.");
                Console.WriteLine("At first level, barbarians can entle bloodlust twice a day.");
            }
            if (userClass == "fighter")
            {
                Console.WriteLine("Fighters start with two shortswords and rusty armor.");
                Console.WriteLine("Fighters can wear any armor, as long they have a sufficient strength score.");

            }

            //This will make sure the app stays open
            Console.ReadLine();
        }
    }
}
