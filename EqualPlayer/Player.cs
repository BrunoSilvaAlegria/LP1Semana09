using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EqualPlayer
{
    public class Player
    {
        public PlayerClass PClass { get; }
        public string Name { get; }
        public Player(PlayerClass pClass, string name)
        {
            PClass = pClass;
            Name = name;
        }

        //GetHashCode method override so that a player is considered unique 
        //in the game if it has the same type and the same name
        public override int GetHashCode() => PClass.GetHashCode() ^ Name.GetHashCode()

        //Equals method override so that a player is considered unique 
        //in the game if it has the same type and the same name
        public override bool Equals(object obj)
        {
            Player other = obj as Player;
            if (other == null) return false;
            return PClass == other.PClass && Name == other.Name;
        }

    }
}