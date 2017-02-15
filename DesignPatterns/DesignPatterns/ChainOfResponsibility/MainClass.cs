/// <summary>
/// The ChainOfResponsibility namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility
{
    using System;

    /// <summary>
    /// Class MainClass.
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // Setup Chain of Responsibility
            Approver director = new Director();
            Approver vicePresident = new VicePresident();
            Approver president = new President();

            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            // Generate and process purchase requests
            Purchase p = new Purchase(2034, 350.00, "Assets");
            director.ProcessRequest(p);

            p = new Purchase(2035, 32590.10, "Project X");
            director.ProcessRequest(p);

            p = new Purchase(2036, 122100.00, "Project Y");
            director.ProcessRequest(p);

            // Wait for user
            Console.ReadKey();
        }
    }
}