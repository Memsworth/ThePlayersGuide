using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class ConsolasAndTelim
    {
        public static void RunProgram()
        {
            Console.WriteLine("Bread is ready.");
            Console.WriteLine("Who is the bread for?");
            string name = Console.ReadLine() ?? throw new NullReferenceException("Should've entered a normal input");
            Console.WriteLine($"Noted: {name} got the bread");
        }
    }
}
