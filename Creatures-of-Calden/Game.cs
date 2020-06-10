using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Creatures_of_Calden
{
    static class Game
    {
        public static CharacterData player1 { get; set; }
        public static void StartGame()
        {
            CharacterCreator characterCreator = new CharacterCreator();
            player1 = characterCreator.CreateCharacter();
            Part1.Story();
            

        }
        public static void EndGame()
        {
            Console.WriteLine("You have died!  The game is over");
            System.Environment.Exit(0);
        }

    }
}
