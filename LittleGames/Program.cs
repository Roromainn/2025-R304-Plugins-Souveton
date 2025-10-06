// See https://aka.ms/new-console-template for more information
using LittleGames;

IConsole console = new SimpleConsole();
Games games = new Games(console);
games.Run();
Console.WriteLine("Good bye");
