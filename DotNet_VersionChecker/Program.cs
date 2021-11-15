using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NNDotNetVersionChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("NN Dot Net Version Checker By N Norton ");
            Console.WriteLine("");
            Console.WriteLine("");
            try
            {
                VersionTest.NNMain();
            }
            catch(Exception e)
            {
                Console.WriteLine("An error occured while trying to check the installed .Net version");
                Console.WriteLine("" + e.ToString());
            }
            Console.WriteLine("Press any key to close.");
            Console.ReadKey();

        }
    }
}
