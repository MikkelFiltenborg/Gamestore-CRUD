namespace Gamestore.Client.Client.Models
{
    public static class GameClient
    {
        private static readonly List<Game> games = new()
        {
            new Game()
            {
                Id = 1,
                Name = "War Thunder",
                Genre = "Battle",
                Price = 00.00M,
                ReleaseDate = new DateTime(2012, 11, 1)
            },
            new Game()
            {
                Id = 2,
                Name = "Star Wars Knight of the Old Republic",
                Genre = "Roleplaying",
                Price = 49.99M,
                ReleaseDate = new DateTime(2003, 7, 3)
            },
            new Game()
            {
                Id = 3,
                Name = "Call of Duty Modern Warfare 2",
                Genre = "FPS",
                Price = 59.99M,
                ReleaseDate = new DateTime(2009, 11, 10)
            },
        };

        public static Game[] GetGames()
        {
            return games.ToArray();
        }

        public static void AddGame(Game game)
        {
            game.Id = games.Max(game => game.Id) + 1;
            games.Add(game);
        }

        public static Game GetGame(int id)
        {
            return games.Find(game => game.Id == id) ?? throw new Exception("Could not find game!");
        }

        public static void UpdateGame(Game updatedGame)
        {
            Game existingGame = GetGame(updatedGame.Id);
            existingGame.Name = updatedGame.Name;
            existingGame.Genre = updatedGame.Genre;
            existingGame.Price = updatedGame.Price;
            existingGame.ReleaseDate = updatedGame.ReleaseDate;
        }

        public static void DeleteGame(int id)
        {
            Game game = GetGame(id);
            games.Remove(game);
        }
    }
}
