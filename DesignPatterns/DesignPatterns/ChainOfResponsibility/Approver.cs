/// <summary>
/// The ChainOfResponsibility namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility
{
    using System;

    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Approver
    {
        /// <summary>
        /// The successor
        /// </summary>
        protected Approver successor;

        /// <summary>
        /// Sets the successor.
        /// </summary>
        /// <param name="successor">The successor.</param>
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        public virtual void ProcessRequest(Purchase purchase)
        {
            if (successor != null)
            {
                successor.ProcessRequest(purchase);
                return;
            }

            Console.WriteLine("Request# {0} requires an executive meeting!",
                  purchase.Number);
        }
    }
}