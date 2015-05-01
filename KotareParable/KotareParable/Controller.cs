using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotareParable
{
    public class Controller
    {

        public Controller()
        {
            
        }

        public void Run()
        {
            View view = new View();
            Model model = new Model();


            view.WelcomeMessage();

            while (model.GameIsActive())
            {
                //GetResponse returns a string (the user input)
                view.GetResponse();
                //Model needs to accept the string returned from GetResponse
                //accept it as an arg to a method on the model
                //model.YesOrNo; //this will return an int that represents an ID
                //model.GetNextNarration(ID) //this returns the string for the next statement by the narrator

                //view.PrintOutcome(statement)


                // while input from user/command line that is not exit, or we reach end of game / game in session is true

                //get input from user

                //pass to model to work out which row from table to get

                //pass that row to view to display

                //continue loop   
            }

            //some view method to print GAME OVER SUCKER
            
        }

      

        


    }
}
