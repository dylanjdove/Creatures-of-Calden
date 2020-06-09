using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Creatures_of_Calden.Story
{
    static class Part1StealthSuccess
    {
        public static char Part1Success()
        {
            Console.WriteLine("You slowly creep toward the commotion, expertly cloaking any sounds you might make.");
            Console.WriteLine("You are able to reach the door without alerting the people belonging to the voices you heard.");
            Console.WriteLine("Now that you are closer, you are able to better make out the voices and what they are saying.");
            Console.WriteLine("Both voices are distinctly male, and have the rough sound of common bandits and layabouts.");
            Console.WriteLine("As you reach the door to the tavern, you are able to peer outside and get a good look at the two people");
            Console.WriteLine("Two men stand a small distance away from the door and to the side, dressed in ragged clothing.");
            Console.WriteLine("They have the look of men who haven't had a decent meal in weeks, and there's a wildness to them.");
            Console.WriteLine("You can make out what they are saying, and it does not sound good for you.  They appear to be discussing your demise.");
            Console.WriteLine("Your options are as follows:  \n1.)  Make a run for it \n2.) Attempt to hide in the tavern  \n3.)  Prepare for battle");
            return UserInput.InputKey();
        }

        public static char Part2Success(char previousChoice)
        {
            Console.WriteLine("As you survey the empty tavern, you notice a spot in a particularly dark corner where you can climb into the rafters.");
            Console.WriteLine("You quickly and quietly make your way to the corner and climb up into the rafters, careful not to leave boot prints in the dust.");
            Console.WriteLine("Just as you settle in you see two men walk into the tavern.  Their rough looks show you they are not here for a fun discussion.");
            Console.WriteLine("They search the otherwise empty tavern quite throughly. Making sure to root through empty boxes and study the ground throughout.");
            if (previousChoice == '3')
            {
                Console.WriteLine("They make particular note of the ale covering the wall and floor where you've shattered the glass you found.");
                Console.WriteLine("You can hear them discussing the still cool ale and trying to decide if the person who shattered the glass is still around.");
                Console.WriteLine("After a somewhat heated debate they decide to finish looking through the tavern for any clues on where you might be hiding.");
                Console.WriteLine("When they find nothing, another heated debate breaks out.  They briefly argue if they should torch the already decrepit tavern.");
                Console.WriteLine("You wait with baited breath until they finally decide it would be a waste of good spirits, concluding that you must have snuck out.");
                Console.WriteLine("The pair of men exit the tavern, and you hear their boots crunching on the gravel until the sound of their footsteps fades into the distance.");
            }
            else
            {
                Console.WriteLine("The men search the tavern until they've left no spot unchecked, concluding that whoever was supposed to be here is long gone.");
                Console.WriteLine("They have a brief and slightly heated discussion on whether or not they should burn the decrepit old tavern, but decide against it.");
                Console.WriteLine("The two men make one last cursory check through the tavern and turn to leave, never even having glanced in your direction.");
                Console.WriteLine("\"Funny,\" you think to yourself, \"Nobody ever seems to look up in these situations.\"");
            }
            Console.WriteLine("You climb down from your hiding place in the rafters with a sigh of relief.  You have successfully avoided a fight you might not have survived.");
            Console.WriteLine("You walk to the entrance and see a trail of dust as the two men ride off on a pair of horses.  They're long gone, and now adventure awaits you!");
            Console.WriteLine("Your options are:  \n1.)  Follow the riders (maybe their going to the palace)  \n2.)  Go the opposite direction of the riders (they seem dangerous)  \n3.)  Take a nap (you're tired from all that hiding)");
            return UserInput.InputKey();
        }
    }
}
