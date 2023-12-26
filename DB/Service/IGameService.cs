
namespace OOP_Lab2.DB.Service
{
    public interface IGameService
    {
        void CreateGame(string player, int rating, bool result);
        void CreateGame(string gameType, string player, string opponent, int rating, bool result);
        void UpdateGames(Game game);
        void DeleteGame(Game game);

    }
}
