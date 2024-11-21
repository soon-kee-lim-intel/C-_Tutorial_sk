using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_FirstSession
{
    using Demo_2ndNamespace;
    using System.Security.Cryptography.X509Certificates;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worlds.");

            // Print the press enter to continue line and pause the command prompt.
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            Demo_2ndNamespace.Program.Main2();
            Console.ReadLine();
        }
         
        public static void Main2()
        {
            Console.WriteLine("Press enter to exit main 2.");
        }
    }
}

namespace Demo_2ndNamespace
{
    public class Program
    {
        public static void Main2()
        {
            Console.WriteLine("Press enter to exit main 2 in 2ndNameSpace.");
        }
    }
}