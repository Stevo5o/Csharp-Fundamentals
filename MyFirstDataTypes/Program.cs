using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Team Fortess Data Store
            // anonymous object
            IEnumerable<Character> teamFortessTwo = new Character[] {
                new Character("Scout", CharacterClass.Offense),
                new Character("Soldier", CharacterClass.Offense),
                new Character("Pyro", CharacterClass.Offense),
                new Character("Demoman", CharacterClass.Defense),
                new Character("Heavy", CharacterClass.Defense),
                new Character("Engineer", CharacterClass.Defense),
                new Character("Medic", CharacterClass.Support),
                new Character("Sniper", CharacterClass.Support),
                new Character("Spy", CharacterClass.Support)	
            };
            #endregion
            // Lanugae INetrated Query

            var query = teamFortessTwo.GroupBy(e => e.CharacterClass);

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var character in group)
                {
                    Console.WriteLine(character.Name);
                }
                Console.WriteLine();
            }
        }
    }
}





