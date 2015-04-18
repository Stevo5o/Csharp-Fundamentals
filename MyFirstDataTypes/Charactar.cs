using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp_Fundamentals.MyFirstDataTypes
{
    public class Character
    {

        public string Name { get; private set; }
        public Character(string name, CharacterClass characterClass)
        {            
            Name = name;
            CharacterClass = characterClass;
        }

        public CharacterClass CharacterClass { get; protected set; }

        public override string ToString()
        {
            return base.ToString() + ", " + CharacterClass;
        }
    }
}

