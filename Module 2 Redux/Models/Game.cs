using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Redux.Models
{
    public class Game : GameMember, Scene
    {
        public GameMember InPlayScene;
        //InPlayScene object refers to value to store character interaction
        // with scene interface + events during run-time.

        //properties:
        public DateTime BeginPlay;
        public DateTime EndPlay;
        public bool Killed;

        //Fields to return functions:
        string input;
        string LocalPlay;
        string SceneInteract;    

        public string currentScene()
        {

            Console.WriteLine("<< Welcome to Technoprolis: >>");
            Console.WriteLine(" ~ What is Bill upto today? :");
            Console.WriteLine(" Press y to access game menu? (n, to main)");
            input = Console.ReadLine();
            LocalPlay = input.ToString();

            if (LocalPlay == "y")
            {
                return "Proceed" + LocalPlay;

            }
            if (LocalPlay == "n")
            {
                return dead();
            }
            else
                return LocalPlay;
        }
    

        public string sceneEvent()
        {
            Console.WriteLine("Bill receives an intercept from ~Parsy~ ");
            Console.WriteLine(" Parsy: How does bill want to proceed? ");
            Console.WriteLine("Read, Train, Hack?");
            //these various terms can be used to return specific actions
            //that the object will behave with accordingly.
            input = Console.ReadLine();
            SceneInteract = input.ToString();

            return SceneInteract;
        }


    }
}
