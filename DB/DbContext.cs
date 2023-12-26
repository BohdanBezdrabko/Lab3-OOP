﻿
namespace OOP_Lab2.DB
{
    public class DbContext
    {
        public List<GameAccount> GameAccounts { get; set; }
        public List<Game> Games { get; set; }
        
        public DbContext()
        {
            GameAccounts = new ();
            Games = new ();
        }

            
    }
}
