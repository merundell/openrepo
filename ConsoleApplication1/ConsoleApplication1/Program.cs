using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.UserInteractive)
            {
                ConsoleMain(args);
            }
            else
            {
                ServiceMain();
            }
        }

        static void ConsoleMain(string[] args)
        {
            var service = new MyServiceHost();

            service.Start();
            
            WaitUntilUserEntersQuit();

            service.Stop();
        }

        static void ServiceMain()
        {

        }

        private static void WaitUntilUserEntersQuit()
        {
            Console.WriteLine();
            Console.WriteLine("Enter 'QUIT' to exit...");
            String userInput = String.Empty;

            while (String.Compare(userInput, "Quit", true, CultureInfo.InvariantCulture) != 0) 
            {
                userInput = Console.ReadLine();
            }
        }
    }
}
