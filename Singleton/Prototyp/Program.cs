using System;

namespace Prototyp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var createdCheatGame = CreateCheatGame();
            ShowGameToSaveInfo("CheatGame", createdCheatGame);

            var gameToSave = GameStartingPoint();
            ShowGameToSaveInfo("Game ", gameToSave);

            gameToSave = createdCheatGame.Clone() as CheatGame;
            gameToSave.Player.Name = "Marek";
            ShowGameToSaveInfo("CheatGame", createdCheatGame);
            ShowGameToSaveInfo("Saved game ", gameToSave);


            Console.ReadKey();
        }

        private static CheatGame GameStartingPoint()
        {
            var startingPlayer = new CheatGame()
            {
                Name = "brak",
                Points = "brak",
                Player = new Player()
                {
                    Name = "brak",
                    Type = "brak"
                }
            };

            return startingPlayer;
        }

        private static CheatGame CreateCheatGame()
        {
            var cheatGame = new CheatGame();
            cheatGame.Name = "Cheated Game";
            cheatGame.Points = "999 ptk";
            cheatGame.Player = new Player()
            {
                Name = "CHEATER",
                Type = "ANY"
            };

            return cheatGame;
        }

        private static void ShowGameToSaveInfo(string typeOfGame, CheatGame startingGame)
        {
            Console.WriteLine("GRA: {0}" +
                              "Nazwa zapisu: {1}, Punkty: {2}, Imie{3}",
                typeOfGame,
                startingGame.Name,
                startingGame.Points,
                startingGame.Player.Name);
        }
    }
}
