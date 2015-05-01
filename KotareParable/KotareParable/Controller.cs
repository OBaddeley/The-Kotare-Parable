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
            //Model model = new Model();

            view.WelcomeMessage();
            view.GetResponse();

            // while input from user/command line that is not exit, or we reach end of game / game in session is true

                //get input from user

                //pass to model to work out which row from table to get

                //pass that row to view to display

                //continue loop



        }

      

        


    }
}
