using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>()
            {
                "Red","Green","Blue","Purple","Azure"
            };

            //Local function declaration. 
            //You can access variables of the parent method. 
            //PrintColors methods appears in intellisense only in Main method scope.
            //Local functions can be async.
            void PrintColors()
            {
                colors.ForEach(t => Console.WriteLine(t));
            }

            PrintColors();

            colors.Add("Black");
            colors.Add("White");
            PrintColors();
        }
    }
}
