/// <summary>
/// The DesignPatterns namespace.
/// </summary>
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            /*
            * Notes:
            * Consult the MainClass of each design pattern.
            */

            while (true)
            {
                Console.WriteLine("------- Select one design -------------");
                Console.WriteLine("--(1)-- Chain Of Responsibility -------");
                Console.WriteLine("--(2)-- Command -----------------------");
                Console.WriteLine("---------------------------------------");
                Console.Write("------- Enter number: --------------- ");
                var input = Console.ReadLine();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine();

                int option = 0;
                if (!int.TryParse(input, out option))
                {
                    if (input.Equals("exit")) break;
                    Console.WriteLine("------- Error: Unknown option! ------");
                    Console.WriteLine("------- Info: type 'exit' to close --");
                    Console.WriteLine("---------------------------------------");
                    Console.WriteLine();
                    continue;
                }

                switch (option)
                {
                    /*
                    * This case is the better choice for the cases when we have a lot of complexity caused by multiple if/else conditions.
                    */
                    case 1:
                        // Run the Chain Of Responsibility example
                        ChainOfResponsibility.MainClass.Run();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine();
                        break;

                    case 2:
                        // Run the Command example
                        Command.MainClass.Run();
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine();
                        break;

                    case 3:
                        ChainOfResponsibility.ATM.ATMClass.GiveMeMoney(150);

                        break;

                    default:
                        Console.WriteLine("------- Error: Invalid option! ------");
                        Console.WriteLine("------- Info: type 'exit' to close --");
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}