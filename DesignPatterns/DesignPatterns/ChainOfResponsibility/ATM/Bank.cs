/// <summary>
/// The ATM namespace.
/// </summary>
namespace DesignPatterns.ChainOfResponsibility.ATM
{
    using System;

    /// <summary>
    /// Class Bank.
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// The hundred
        /// </summary>
        private int hundred;

        /// <summary>
        /// The fifty
        /// </summary>
        private int fifty;

        /// <summary>
        /// The twenty
        /// </summary>
        private int twenty;

        /// <summary>
        /// The ten
        /// </summary>
        private int ten;

        /// <summary>
        /// The five
        /// </summary>
        private int five;

        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        public Bank()
        {
            this.hundred = 1;
            this.fifty = 10;
            this.twenty = 100;
            this.ten = 1000;
            this.five = 1000;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public Bank(Bank notes)
        {
            this.hundred = notes.hundred;
            this.fifty = notes.fifty;
            this.twenty = notes.twenty;
            this.ten = notes.ten;
            this.five = notes.five;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bank" /> class.
        /// </summary>
        /// <param name="hundred">The hundred.</param>
        /// <param name="fifty">The fifty.</param>
        /// <param name="twenty">The twenty.</param>
        /// <param name="ten">The ten.</param>
        /// <param name="five">The five.</param>
        public Bank(int hundred, int fifty, int twenty, int ten, int five)
        {
            this.hundred = hundred;
            this.fifty = fifty;
            this.twenty = twenty;
            this.ten = ten;
            this.five = five;
        }

        #endregion Ctor

        /// <summary>
        /// Gets or sets the hundred.
        /// </summary>
        /// <value>The hundred.</value>
        public int Hundred
        {
            get { return this.hundred; }
            set { this.hundred = value; }
        }

        /// <summary>
        /// Gets or sets the fifty.
        /// </summary>
        /// <value>The fifty.</value>
        public int Fifty
        {
            get { return this.fifty; }
            set { this.fifty = value; }
        }

        /// <summary>
        /// Gets or sets the twenty.
        /// </summary>
        /// <value>The twenty.</value>
        public int Twenty
        {
            get { return this.twenty; }
            set { this.twenty = value; }
        }

        /// <summary>
        /// Gets or sets the ten.
        /// </summary>
        /// <value>The ten.</value>
        public int Ten
        {
            get { return this.ten; }
            set { this.ten = value; }
        }

        /// <summary>
        /// Gets or sets the five.
        /// </summary>
        /// <value>The five.</value>
        public int Five
        {
            get { return this.five; }
            set { this.five = value; }
        }

        /// <summary>
        /// Gets the total.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int GetTotal()
        {
            return this.hundred * 100 + this.fifty * 50 + this.twenty * 20 + this.ten * 10 + this.five * 5;
        }
    }
}