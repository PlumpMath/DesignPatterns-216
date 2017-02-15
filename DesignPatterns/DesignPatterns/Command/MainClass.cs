/// <summary>
/// The Command namespace.
/// </summary>
namespace DesignPatterns.Command
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
            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            // Wait for user
            Console.ReadKey();
        }
    }
}