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
         
        }


        // read input from console
        public string GetResponse()
        {
            Console.WriteLine("\nWhat is your decision?");
            var response = Console.ReadLine();
            return response;
        }
        

        // read from model table
        public void PrintOutcome(string statement)
        {
            Console.WriteLine(statement);  // row from table table.description
        }

        public void InvalidResponse()
        {
            Console.WriteLine("Try again, moron!");

        }


        public void GameOver()
        {
            Console.WriteLine("\nGAME OVER!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
