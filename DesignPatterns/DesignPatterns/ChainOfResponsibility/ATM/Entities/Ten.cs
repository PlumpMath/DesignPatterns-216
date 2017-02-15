/// <summary>
/// The Entities namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility.ATM.Entities
{
    using System;

    /// <summary>
    /// Class Ten.
    /// </summary>
    public class Ten : Cash
    {
        /// <summary>
        /// The value
        /// </summary>
        private static int value = 10;

        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="money">The money.</param>
        /// <param name="bank">The bank.</param>
        public override void ProcessRequest(int money, Bank bank)
        {
            // Get number of notes
            var numberOfNotes = (int)(money / value);

            // If doesn't exist any note, proceed
            if (bank.Ten <= 0 || numberOfNotes < 1)
            {
                base.ProcessRequest(money, bank);
                return;
            }

            if (bank.Ten < numberOfNotes)
            {
                numberOfNotes = bank.Ten;
            }

            if (bank.Ten >= numberOfNotes)
            {
                // Discount the number of notes from bank
                bank.Ten -= numberOfNotes;

                // Reduce the amount to give in notes.
                money -= numberOfNotes * value;
            }

            // Final case, when doesn't exist more money to give.
            if (money == 0)
            {
                Console.WriteLine("Give {0} note(s) of {1}€", numberOfNotes, value);
                return;
            }

            Console.WriteLine("Give {0} note(s) of {1}€", numberOfNotes, value);

            base.ProcessRequest(money, bank);
        }
    }
}