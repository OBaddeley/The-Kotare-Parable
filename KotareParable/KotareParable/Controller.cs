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
            
            //view.WelcomeMessage();

            while (model.GameIsActive())
            {
                //GetResponse returns a string (the user input)
                var response = view.GetResponse();
                ////Model needs to accept the string returned from GetResponse
                //accept it as an arg to a method on the model
                var res = model.CheckResponse(response);
                if (res == 0)
                {
                    view.
                }
                

                //var ID = model.YesOrNo(response); //this will return an int that represents an ID

                // var statement = model.GetNextNarration(ID);
                //this returns the string for the next statement by the narrator

                // view.PrintOutcome(statement);


            }

            //some view method to print GAME OVER SUCKER
            view.GameOver();

           
        }

      

        


    }
}
