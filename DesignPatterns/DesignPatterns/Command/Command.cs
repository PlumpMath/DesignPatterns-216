/// <summary>
/// The Command namespace.
/// </summary>
namespace DesignPatterns.Command
{
    using System;

    /// <summary>
    /// The 'Command' abstract class
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// Executes this instance.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Uns the execute.
        /// </summary>
        public abstract void UnExecute();
    }
}