using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();
            Console.ReadKey();
        }
        /// <summary>
        /// Displays a greeting to the user 
        /// </summary>
        static void DisplayGreeting()
        {
            Console.WriteLine("Hello World");    
        }
    }
}
