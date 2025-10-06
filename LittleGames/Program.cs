// See https://aka.ms/new-console-template for more information
using GameBase;
using LittleGames;

IConsole console = new SimpleConsole();
Games games = new Games(console);
games.AddGame(new GuessIT());
games.AddGame(new Craps());
games.Run();
Console.WriteLine("Good bye");
