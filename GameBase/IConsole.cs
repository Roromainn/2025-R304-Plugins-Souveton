using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase
{
    /// <summary>
    /// Adapter for a console
    /// </summary>
    public interface IConsole
    {
        /// <summary>
        /// Write a message to the console
        /// </summary>
        /// <param name="message">the message</param>
        void Write(string message);

        /// <summary>
        /// Gets a string (CR-terminated) from the console
        /// </summary>
        /// <param name="prompt">The message to show</param>
        /// <returns>the string readed (may be empty or null)</returns>
        string? ReadLine(string prompt);

        /// <summary>
        /// Ask the user to choose a string between many choices
        /// </summary>
        /// <param name="prompts">the differents choices</param>
        /// <returns>the choose made by the user (empty to canceled)</returns>
        string Choose(string[] prompts);

        /// <summary>
        /// Make a pause
        /// </summary>
        /// <param name="message">the message to show</param>
        void Pause(string message);
    }
}
