using System;

namespace EqualPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test code
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            foreach (Player p in setOfPlayers)
            {
                Console.WriteLine($"{p.Name} is a {p.PClass}");
            }
            
        }
    }
}
