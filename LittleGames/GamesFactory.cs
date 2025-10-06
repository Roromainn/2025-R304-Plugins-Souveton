using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleGames
{
    /// <summary>
    /// Fabrique de jeux (singleton)
    /// </summary>
    public class GamesFactory
    {
        /// <summary>
        /// instance du jeu
        /// </summary>
        private static GamesFactory instance;

        /// <summary>
        /// Dictionnaire des jeu
        /// </summary>
        private Dictionary<string, ICreateGame> builders;
        
        /// <summary>
        /// Constructeur privé du singleton
        /// </summary>
        private GamesFactory()
        {
            builders = new Dictionary<string, ICreateGame>();
        }

        /// <summary>
        /// Accès à l'instance/création
        /// </summary>
        public static GamesFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GamesFactory();
                }
                return instance;
            }
        }

        /// <summary>
        ///  Retourne la liste des noms des jeux enregistrés
        /// </summary>
        public string[] Games
        {
            get
            {
                string[] keys = new string[builders.Count];
                builders.Keys.CopyTo(keys, 0);
                return keys;
            }
        }

        /// <summary>
        /// Ajoute un jeu à la fabrique
        /// </summary>
        /// <param name="name">nom du jeu</param>
        /// <param name="builder">constructeur du jeu</param>
        public void Register(string name, ICreateGame builder)
        {
            builders[name] = builder;
        }


        /// <summary>
        /// Crée une instance du jeu demandé
        /// </summary>
        /// <param name="name">nom du jeu</param>
        /// <returns>Le jeu que l'on vient de creer</returns>
        /// <exception cref="Exception">Jeu introuvable</exception>
        public IGame Create(string name)
        {
            if (builders.ContainsKey(name))
            {
                return builders[name].CreateGame();
            }
            else
            {
                throw new Exception("Jeu non trouvé : " + name);
            }
        }
    }
}
