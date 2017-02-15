/// <summary>
/// The ATM namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility.ATM
{
    using System;

    /// <summary>
    /// Class Cash.
    /// </summary>
    public class Cash
    {
        /// <summary>
        /// The successor
        /// </summary>
        protected Cash successor;

        /// <summary>
        /// Sets the successor.
        /// </summary>
        /// <param name="successor">The successor.</param>
        public void SetSuccessor(Cash successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="money">The money.</param>
        /// <param name="bank">The bank.</param>
        public virtual void ProcessRequest(int money, Bank bank)
        {
            if (money > bank.GetTotal())
            {
                Console.WriteLine("[end of the line] - Request could not processed more because the machine doesn't have that amount.");
                return;
            }

            if (this.successor != null)
            {
                successor.ProcessRequest(money, bank);
                return;
            }

            Console.WriteLine("[end of the line] - Request could not processed more to this amount: {0}", money);
        }
    }
}