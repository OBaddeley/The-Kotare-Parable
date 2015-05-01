using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotareParable
{
    public class View
    {

        // print welcome msg  

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to THE KOTARE PARABLE\n");
            Console.WriteLine("You wake up in a dark room. You have no idea how you got here, but you know you need to escape! " +
                              "\nYou try the door and are surprised to find it unlocked." +
                              "\nThe hallway outside goes left and right, which way will you go?");
         
        }


        // read input from console
        public void GetResponse()
        {
            Console.WriteLine("\nWhat is your decision?");
            Console.ReadLine();
        }
        

        // read from model table
        //public void PrintOutcome(//get tablerow from controller)
        //{
        //    // ? new db instance

        //    Console.WriteLine();  // row from table table.description

        //}



    }
}
