/// <summary>
/// The ChainOfResponsibility namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility
{
    using System;

    /// <summary>
    /// Class holding request details
    /// </summary>
    public class Purchase
    {
        /// <summary>
        /// The _number
        /// </summary>
        private int _number;

        /// <summary>
        /// The _amount
        /// </summary>
        private double _amount;

        /// <summary>
        /// The _purpose
        /// </summary>
        private string _purpose;

        // Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <param name="amount">The amount.</param>
        /// <param name="purpose">The purpose.</param>
        public Purchase(int number, double amount, string purpose)
        {
            this._number = number;
            this._amount = amount;
            this._purpose = purpose;
        }

        // Gets or sets purchase number
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        // Gets or sets purchase amount
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>The amount.</value>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        // Gets or sets purchase purpose
        /// <summary>
        /// Gets or sets the purpose.
        /// </summary>
        /// <value>The purpose.</value>
        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}