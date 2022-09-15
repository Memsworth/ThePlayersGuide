using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comments
{
    internal class TheThingNamer
    {
        public static void RunProgram()
        {
            //Asking for objectInput
            Console.WriteLine("What kind of the thing are we talking about?");
            string inputA = Console.ReadLine() ?? throw new NullReferenceException();

            
            //Describing objectShape
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string inputB = Console.ReadLine() ?? throw new NullReferenceException();

            //Suffix
            string inputC = "of Doom";

            //Device version
            string inputD = "3000";

            Console.WriteLine($"The {inputB} {inputA} {inputC} {inputD}!");
        }
    }
}
