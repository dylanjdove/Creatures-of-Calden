using System;
using System.Collections.Generic;
using System.Text;

namespace Creatures_of_Calden.Story
{
    static class Part1StealthFailure
    {
        public static char Part1Failure()
        {
            Console.WriteLine("You slowly creep toward the door, doing everything in your power to remain stealthy.");
            Console.WriteLine("Unfortunately for you, it appears that everything in your power is simply not enough.");
            Console.WriteLine("The two people outside the tavern hear you walking toward the door.");
            Console.WriteLine("You hear the two people stop talking and begin to cautiously approach your position.");
            Console.WriteLine("Your options are:  \n1.)  Make a run for it \n2.)  Attempt to hide in the tavern  \n3.)  Prepare for battle ");
            return UserInput.InputKey();
        }

        public static char Part2Failure(char previousChoice)
        {
            Console.WriteLine("You glance around the room looking for somewhere to hide.  There aren't many options, but you'll find something.");
            Console.WriteLine("As you survey the room, you notice a spot in a particularly dark corner where you can climb into the rafters.");
            Console.WriteLine("You rush there as fast as you can, hoping against hope that you can hide yourself before anyone notices.");
            Console.WriteLine("You make it up into the rafters just as two men walk into the tavern, weapons drawn.  They seem to have heard you.");
            Console.WriteLine("As you gaze at them in horror, you notice that you didn't think to cover your tracks in the dusty floor of the tavern.");
            Console.WriteLine("You've left a clear trail right to your hiding place, and the two men have found you.  They begin shouting in excitement.");
            Console.WriteLine("The two bandits approach you with obvious glee, ready to eviscerate you, you're certain.");
            Console.WriteLine("Your options are:  \n1.)  Prepare for battle  \n2.)  Surrender");
            return UserInput.InputKey();
        }
    }
}
