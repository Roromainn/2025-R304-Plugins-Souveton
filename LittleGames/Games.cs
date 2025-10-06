using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LittleGames
{
    /// <summary>
    /// Can play many games
    /// </summary>
    public class Games 
    {
        /// <summary>
        /// Dictionnaire des jeux
        /// </summary>
        private Dictionary<string,IGame> games;
        /// <summary>
        /// Console dans laquelle ca se passe
        /// </summary>
        private IConsole console;
        /// <summary>
        /// Score du jeu
        /// </summary>
        private int score;

        /// <summary>
        /// Initialize the games
        /// </summary>
        /// <param name="console">the console used by the games</param>
        public Games(IConsole console)
        {
            this.console = console;
            games = new Dictionary<string, IGame>();
            score= 0;                   
        }

        /// <summary>
        /// Add a new game
        /// </summary>
        /// <param name="g">the game</param>
        public void AddGame(IGame g)
        {
            games[g.Name] = g;
        }

        /// <summary>
        /// Run : user can play any game, until he wants to exit. Score is computed after each play.
        /// </summary>
        public void Run()
        {
            console.Write("Welcome the the Games !");
            string choice = console.Choose(games.Keys.ToArray());
            while (choice != string.Empty)
            {                
                int s = games[choice].Run(console);
                score += s;
                console.Write(string.Format("Current score : {0}", score));
                choice = console.Choose(games.Keys.ToArray());
            }

            string msg = string.Format("Games ended. Your final score is {0}", score);
            console.Write(msg);
        }

    }
}
