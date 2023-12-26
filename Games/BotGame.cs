namespace OOP_Lab2.Games
{
    class BotGame: Game
    {
        public override int GameRating(int rating)
        {
            return rating / 2;
        }
        public BotGame(string user, int rating, bool result) : base(user,"BOT", rating, result)
        {

        }
    }
}