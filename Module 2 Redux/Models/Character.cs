using System;
using System.Collections.Generic;
using System.Text;

namespace Module_2_Redux.Models
{
    public class Character
    {
        //properties
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        //fields
        public int Xp;
        public int Points;
        public bool Alive;

        //default constructor
        public Character() { }

        public string getPlayer()
        {
            return PlayerName + " > Status: " + Alive;
        }

        //leveling function to gain xp for player-stats
        // how to trigger this function?
        // like a calculator
        //how to get xp to read as like the most up to date one?
        public int LvlUp()
        {
            if (Points > 10)
            {
                return Xp + 1;
            }

            if (Points <= 10)
            {
                return Xp;
            }
            else return Points;

        }

        //print override method
        public override string ToString()
        {
            return "Id: " + PlayerID + " Name: " + PlayerName + " Xp: " +
                Xp + " Points: " + Points + " Status: " + Alive;
        }

        //needs a flag
        public string dead()
        {

            if (Alive == true)
            {
                Console.WriteLine("Player health is regenerating. ");
            }
            if (Alive != true)
            {
                return " (Terminated) ";
            }
            else
            {
                Environment.Exit(0);
                return " Game Over ";

            }

        }
    }

    public class GameMember : Character, Scene
    {
        public Character MainCharacter;

        //properties of sub-class or na?
       
        public override string ToString()
        {
            return PlayerName + " is currently playing as Bill Gnant.";
        }

        //test interface here: hmm how to call in main?
        void Scene.createScene(string playerName, DateTime beginPlay)
        {
            Console.WriteLine("Testing working ");
            
            throw new NotImplementedException();
        }
    }
}
