// See https://aka.ms/new-console-template for more information


using BowlingCalculator.Interfaces;
using BowlingCalculator;
using Microsoft.Extensions.DependencyInjection;

var builder = new ServiceCollection()
    .AddSingleton<IGame, BowlingGame>()
    .AddSingleton<IFrame, BowlingFrame>()
    .BuildServiceProvider();


var game = builder.GetRequiredService<IGame>();
game.RecordScore(new List<int> { 10, 10, 10 }); 
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
game.RecordScore(new List<int> { 10, 10, 10 });
Console.WriteLine(String.Format("Final score {0}", game.PlayGame()));
game.ResetGame();
