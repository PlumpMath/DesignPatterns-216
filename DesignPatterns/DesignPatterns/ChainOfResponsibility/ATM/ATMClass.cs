/// <summary>
/// The ATM namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility.ATM
{
    using System;

    using DesignPatterns.ChainOfResponsibility.ATM.Entities;

    /// <summary>
    /// Class ATMClass.
    /// </summary>
    public class ATMClass
    {
        /// <summary>
        /// Gives me money.
        /// </summary>
        /// <param name="money">The money.</param>
        public static void GiveMeMoney(int money)
        {
            // Setup entities
            Cash hundred = new Hundred();
            Cash fifty = new Fifty();
            Cash twenty = new Twenty();
            Cash ten = new Ten();
            Cash five = new Five();

            // Setup Chain of Responsibility
            hundred.SetSuccessor(fifty);
            fifty.SetSuccessor(twenty);
            twenty.SetSuccessor(ten);
            ten.SetSuccessor(five);

            // Generate and process ATM requests
            int moneyInBank = 1000;
            var bank = new Bank(moneyInBank / 100, moneyInBank / 50, moneyInBank / 20, moneyInBank / 10, moneyInBank / 5);

            // hundred.ProcessRequest(money, bank);

            // Testing multiple requests
            for (int i = 1; i < 150; i++)
            {
                // Request #i
                Console.WriteLine("Request #{0}\n", i);
                Console.WriteLine("Amount requested: {0}€", money);
                Console.WriteLine("Amount available: {0}€\n", bank.GetTotal());
                hundred.ProcessRequest(money, bank);
                Console.WriteLine("\nEnd Of Request #{0}\n-----------------\n", i);

                var randomNumber = new Random().Next(5, 200);
                money = ((int)(randomNumber / 5)) * 5;
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}