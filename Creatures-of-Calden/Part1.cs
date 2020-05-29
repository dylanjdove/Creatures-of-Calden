using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Creatures_of_Calden
{
    class Part1
    {
        public void Story()
        {
            UserInput input = new UserInput();

            Console.WriteLine("You find yourself awakening in an unfamiliar location, drowsy and disoriented.  You're in what appears to be a once-fine tavern that has gone to disrepair.  \n");
            Console.WriteLine("There are no patrons, and the fire is unlit. You are sitting hunched over in a corner table, with a decent view of the entire room. \n");
            Console.WriteLine("You can see that the door is hanging off it's hinges and there's no propieter in sight.  The whole room appears to be covered in a substantial layer of dust.  \n");
            Console.WriteLine("Oddly, you have what appears to be a clean glass full of ale on the table in front of you. In this game, you will be presented with 3 options for each action you may take.  Remember to choose wisely.");
            Console.WriteLine("You have three options you may take: \n1.) Drink from the glass, \n2.) Ignore the glass \n3.) Destroy the glass.");

            char choice = input.InputKey();
            char choice2;

            if (choice == '1')
            {
                Console.WriteLine("As you bring the glass to your lips, you notice the ale has a strong, earthy scent.  It smells like ale, but not exactly like the ale you're used to.");
                Console.WriteLine("This is your first hint that wherever you are, it must not be anywhere near where you come from.  You shrug your shoulders slightly, deciding to let fate control your path.");
                Console.WriteLine("The ale's taste perfectly matches its scent, and the drink renews your body and helps you shake off the remaining traces of confusion from waking up in an empty and unfamiliar tavern.");
                Console.WriteLine("Since the first drink seemed to be nothing short of helpful, you decide to down the rest of the glass.  Just as you're wiping the foam from your lips, you hear a voice coming from nowhere.\n");
                Console.WriteLine($"\"Hello, {Game.player1.UserName}!  Allow me to be the first to welcome you to the wonderful land of Calden.  Well, I suppose I will be the only one to welcome you.");
                Console.WriteLine($"You see, my fledgeling {Game.player1.Class}, the people of Calden have fallen under a rather cruel curse.  This curse warps their minds and in some cases transforms their bodies.");
                Console.WriteLine($"It is my hope that you will save these people.  I would do it myself, but my rival is preventing me from intervening.  She's a powerful wizardess and the one who cast this curse.");
                Console.WriteLine("You will need to fight your way through the many guardians she has set around her castle, and then destroy her throne.  Only then will the curse be lifted.  I truly believe you can do this.");
                Console.WriteLine("If it feels like your agency has been taken from you, and you didn't ask for this quest, all I can do is apologize.  It wasn't my desire, but my only option.  You are all my people have.");
                Console.WriteLine("I will aid you in every way possible throughout your journey, but I will be limited in the ways I can assist.\"\n \n");
                Console.WriteLine("As the voice finishes speaking, you hear a commotion outside.  There appear to be two distinct voices arguing with each other, though you can't quite make out their words.");
                Console.WriteLine("Your options are:  \n1.) Investigate the commotion \n2.) Attempt to hide \n3.) Prepare for battle");
                choice2 = input.InputKey();
            }


            else if (choice == '2')
            {
                Console.WriteLine("You choose to ignore the glass, distrustful of a drink you haven't seen prepared.  You glance around your surroundings, but you remain a bit disoriented.");
                Console.WriteLine("As you survey your surroundings, you rise from your seat.  You walk around the room, checking to see if there is anything of interest.");
                Console.WriteLine("After around a minute of exploring, you hear a disembodied voice speak to you from nowhere in particular.");
                Console.WriteLine($"\"Hello, {Game.player1.UserName}!  I had hoped you would accept my olive branch, but time has run out.  I must be brief, but allow me to summarize.  You are in the land of Calden.");
                Console.WriteLine("The people of Calden have fallen to a foul curse, and you are the only one who can save them.  Coincidentally, saving them is the only way to save yourself.  It's unfortunate but true.");
                Console.WriteLine("You must break into the castle outside of the town you are in and find the throne room.  You must then destroy the throne.  I will attempt to aid in any way I can, though it won't be much.");
                Console.WriteLine($"Right now, there are two bandits approaching this tavern.  They have been hired to kill you.  I suggest you kill them first.  I will talk to you more when I can.  Goodbye, fledgling {Game.player1.Class}\"");
                Console.WriteLine("Your options are:  \n1.) Investigate the commotion \n2.) Attempt to hide \n3.) Prepare for battle");
                choice2 = input.InputKey();
            }

            else if (choice == '3')
            {
                Console.WriteLine("You pick up the glass, lobbing it across the room.  As the glass hits the wall, it explodes in a shower of glass shards and ale.");
                Console.WriteLine("As the ale runs down the wall, you hear a disembodied voice coming from nowhere you can tell.");
                Console.WriteLine("\"You should NOT have done that,\" the voice says.  \"I'm quite certain you will regret it.  I don't have the time to explain why at the moment, so you will have to take my word.");
                Console.WriteLine("There are two bandits outside this tavern that will be storming in at any moment.  I suggest you prepare yourself.  They will be here on strict orders to kill you.  I would help if I could.");
                Console.WriteLine("Unfortunately, I don't have the time to explain why that isn't possible.  All I can say is that if you want to go home you will need to fight your way into the castle outside of town.");
                Console.WriteLine("Once you're inside, find the throne room and destroy the throne.  We're out of time.  Prepare yourself!\"");
                Console.WriteLine("As the voice finishes speaking you hear two new voices coming from outside the tavern.  It appears the sound of you destroying the glass has alerted them to your location.");
                Console.WriteLine("Your options are:  \n1.) Investigate and attempt to talk to the men  \n2.) Attempt to hide \n3.) Prepare for battle");
                choice2 = input.InputKey();
            }


            Console.ReadLine();
        }
    }
}
