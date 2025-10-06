using GameBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    public static class Init
    {
        public static void Register()
        {
            GamesFactory.Instance.Register("NvJeu", new CreateNvJeu());
        }
    }

    /// <summary>
    /// Simple game : player must guess random number between 1 and 100.
    /// </summary>
    public class NvJeu : IGame
    {
        public string Name => "Bonjour";

        public string Description => "Tou have to write 'Bonjour'";

        public int Run(IConsole console)
        {
            int score = 0;
            bool found = false;
            string res;

            console.Write("Write 'Bonjour'");
            res = console.ReadLine("Repondez :");
            if (res == "Bonjour")
            {
                score += 1;
            }
            return score;
        }
    }

    public class CreateNvJeu : ICreateGame
    {
        public IGame CreateGame()
        {
            return new NvJeu();
        }
    }
}
