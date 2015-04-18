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
                new Character("Scout","", CharacterClass.Offense, 200000),
                new Character("Soldier","", CharacterClass.Offense, 200000),
                new Character("Pyro","", CharacterClass.Offense, 200000),
                new Character("Demoman","", CharacterClass.Defense, 200000),
                new Character("Heavy","", CharacterClass.Defense, 200000),
                new Character("Engineer","", CharacterClass.Defense, 200000),
                new Character("Medic","", CharacterClass.Support, 200000),
                new Character("Sniper","", CharacterClass.Support, 200000),
                new Character("Spy","", CharacterClass.Support, 200000)	
            };
            #endregion

            // Lanugae INetrated Query
            var query = from character in teamFortessTwo
                        where character.
	{
		 
	}
        }
    }
}





