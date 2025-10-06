// See https://aka.ms/new-console-template for more information
using GameBase;
using LittleGames;

string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
string directory = Path.GetDirectoryName(exePath);
string plugins = Path.Combine(directory, "plugins");
var manager = new PluginManager(plugins);
manager.LoadPlugins();




IConsole console = new SimpleConsole();
Games games = new Games(console);
GamesFactory gamefactory = GamesFactory.Instance;
foreach (string gamename in gamefactory.Games)
{
    games.AddGame(gamefactory.Create(gamename));
}
games.Run();
Console.WriteLine("Good bye");
