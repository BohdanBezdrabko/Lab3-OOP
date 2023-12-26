using OOP_Lab2.DB.Repository;
using OOP_Lab2.DB.Service;
using OOP_Lab2.DB;

class Program
{
    static void Main()
    {
        DbContext dbContext = new DbContext();
        GameRepository gameRepository = new GameRepository(dbContext);
        GameAccountRepository gameAccountRepository = new GameAccountRepository(dbContext);
        GameAccountService gameAccountService = new GameAccountService(gameAccountRepository);
        GameService gameService = new GameService(gameRepository, gameAccountRepository);

        try
        {
            gameAccountService.CreateGameAccount("base","Serhii", 200);
            gameAccountService.CreateGameAccount("premium", "Polia", 250);
            gameAccountService.CreateGameAccount("streak", "Max", 300);
            gameAccountService.CreateGameAccount("premium", "Nazar", 250);

            gameService.CreateGame("Serhii", 20, true);

            gameService.CreateGame("standart", "Max", "Nazar", 50, true);

            gameService.CreateGame("standart", "Polia", "Serhii", 70, false);

            gameService.CreateGame("training", "Serhii", "Nazar", 120, true);
            gameService.CreateGame("training", "Nazar", "Polia", 60, true);


            gameService.PrintGames();

            var serhiiAccount = gameAccountRepository.ReadGameAccountByName("Serhii");
            var maxAccount = gameAccountRepository.ReadGameAccountByName("Max");
            var poliaAccount = gameAccountRepository.ReadGameAccountByName("Polia");
            var nazarAccount = gameAccountRepository.ReadGameAccountByName("Nazar");
            gameService.PrintGames(serhiiAccount);
            gameService.PrintGames(maxAccount);
            gameService.PrintGames(poliaAccount);
            gameService.PrintGames(nazarAccount);



        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error: {ex.Message}");
        }
    }
}
