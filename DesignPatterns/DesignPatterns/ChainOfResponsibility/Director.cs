/// <summary>
/// The ChainOfResponsibility namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility
{
    using System;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class Director : Approver
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
                return; // Return because cannot proceed with this action.
            }

            // Call the base method to continue for it successor.
            base.ProcessRequest(purchase);
        }
    }
}