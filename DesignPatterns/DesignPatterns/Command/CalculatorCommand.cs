/// <summary>
/// The Command namespace.
/// </summary>
namespace DesignPatterns.Command
{
    using System;

    /// <summary>
    /// The 'ConcreteCommand' class
    /// </summary>
    public class CalculatorCommand : Command
    {
        /// <summary>
        /// The _operator
        /// </summary>
        private char _operator;

        /// <summary>
        /// The _operand
        /// </summary>
        private int _operand;

        /// <summary>
        /// The _calculator
        /// </summary>
        private Calculator _calculator;

        // Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorCommand"/> class.
        /// </summary>
        /// <param name="calculator">The calculator.</param>
        /// <param name="operator">The operator.</param>
        /// <param name="operand">The operand.</param>
        public CalculatorCommand(Calculator calculator, char @operator, int operand)
        {
            this._calculator = calculator;
            this._operator = @operator;
            this._operand = operand;
        }

        // Gets operator
        /// <summary>
        /// Sets the operator.
        /// </summary>
        /// <value>The operator.</value>
        public char Operator
        {
            set { _operator = value; }
        }

        // Get operand
        /// <summary>
        /// Sets the operand.
        /// </summary>
        /// <value>The operand.</value>
        public int Operand
        {
            set { _operand = value; }
        }

        // Execute new command
        /// <summary>
        /// Executes this instance.
        /// </summary>
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        // Un execute last command
        /// <summary>
        /// Uns the execute.
        /// </summary>
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        // Returns opposite operator for given operator
        /// <summary>
        /// Undoes the specified operator.
        /// </summary>
        /// <param name="operator">The operator.</param>
        /// <returns>System.Char.</returns>
        /// <exception cref="System.ArgumentException">@operator</exception>
        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new
                 ArgumentException("@operator");
            }
        }
    }
}