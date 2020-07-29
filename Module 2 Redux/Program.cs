using Module_2_Redux;
using Module_2_Redux.Models;
using System;
using System.Reflection;

//A. Cox
//SD-725 "Portals of Technoprolis"
// Module - Ongoing Project for Term

/* Goal: Review and re-load Module2-hw as new reposit
 */

namespace Module_2_Redux
{
    class Program
    {
        //interface implemented outside of Main? 

        static void Main(string[] args)
        {
            //local variables:
            string input;
            int gamepts;

            //instance of extended class GameMember : Character main class hierarchy
            GameMember newGameMember = new GameMember();

            //instace of Game Class to test methods, Game extends GameMember
            Game inScene = new Game();

            //to instantiate objects in program class
            newGameMember.PlayerID = 001;
            newGameMember.PlayerName = " Juan Soto";

            //instance of extended class Player
            inScene.BeginPlay = new DateTime(2022, 07, 22);
            inScene.EndPlay = new DateTime();
            Console.WriteLine("Testing initial properties of class structure.");

            //local var to test lvl up function
            int GainPoints = 2;
            //testing fields:
            newGameMember.Points = 9;
            newGameMember.Xp = 1;

            Console.WriteLine(newGameMember.ToString());
            //prior to LvlUp
            Console.WriteLine(newGameMember.LvlUp());

            gamepts = newGameMember.Points + GainPoints;
            input = gamepts.ToString();

            //as int: (method is coded as int)
            Console.WriteLine(gamepts);
            //as string:
            Console.WriteLine(input);

            //method calls from functions in your obj. classes

            //--> pick up here:

            inScene.currentScene();

            inScene.sceneEvent();

            //testing kill method:
            newGameMember.dead();

        }
    }
}
