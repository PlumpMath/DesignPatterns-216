/// <summary>
/// The ChainOfResponsibility namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility
{
    using System;

    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    public class President : Approver
    {
        /// <summary>
        /// Processes the request.
        /// </summary>
        /// <param name="purchase">The purchase.</param>
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                  this.GetType().Name, purchase.Number);
                return;
            }

            base.ProcessRequest(purchase);
        }
    }
}