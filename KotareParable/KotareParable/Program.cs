using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotareParable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "THE KOTARE PARABLE";

            Controller control = new Controller();
            control.Run();

            Console.ReadLine();
        }
    }
}
