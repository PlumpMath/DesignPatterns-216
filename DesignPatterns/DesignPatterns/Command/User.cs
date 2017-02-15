/// <summary>
/// The Command namespace.
/// </summary>
namespace DesignPatterns.Command
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Invoker' class
    /// </summary>
    public class User
    {
        // Initializers
        /// <summary>
        /// The _calculator
        /// </summary>
        private Calculator _calculator = new Calculator();

        /// <summary>
        /// The _commands
        /// </summary>
        private List<Command> _commands = new List<Command>();

        /// <summary>
        /// The _current
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Redoes the specified levels.
        /// </summary>
        /// <param name="levels">The levels.</param>
        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    Command command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        /// <summary>
        /// Undoes the specified levels.
        /// </summary>
        /// <param name="levels">The levels.</param>
        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations
            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    Command command = _commands[--_current] as Command;
                    command.UnExecute();
                }
            }
        }

        /// <summary>
        /// Computes the specified operator.
        /// </summary>
        /// <param name="operator">The operator.</param>
        /// <param name="operand">The operand.</param>
        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it
            Command command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            // Add command to undo list
            _commands.Add(command);
            _current++;
        }
    }
}