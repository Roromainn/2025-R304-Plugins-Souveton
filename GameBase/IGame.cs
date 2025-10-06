using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBase
{
    public interface ICreateGame
    {
        /// <summary>
        /// Create a new game
        /// </summary>
        /// <returns></returns>
        IGame CreateGame();
    }


    /// <summary>
    /// A simple game
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Run the game
        /// </summary>
        /// <returns>the score of the player</returns>
        /// <param name="console">the console to run the game</param>
        int Run(IConsole console);
        /// <summary>
        /// Gives the name of the game
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Gives a short description of the game
        /// </summary>
        string Description { get; }
    }
}
