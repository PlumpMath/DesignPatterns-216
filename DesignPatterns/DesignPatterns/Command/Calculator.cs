/// <summary>
/// The Command namespace.
/// </summary>
namespace DesignPatterns.Command
{
    using System;

    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// The _curr
        /// </summary>
        private int _curr = 0;

        /// <summary>
        /// Operations the specified operator.
        /// </summary>
        /// <param name="operator">The operator.</param>
        /// <param name="operand">The operand.</param>
        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine(
              "Current value = {0,3} (following {1} {2})",
              _curr, @operator, operand);
        }
    }
}