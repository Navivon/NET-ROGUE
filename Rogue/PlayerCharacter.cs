using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue
{
    public enum Race
    {
        Human,
        Elf,
        Orc
    }
    public enum Class
    {
        Meele,
        Range
    }
    internal class PlayerCharacter
    {
       
        public string name;
        public Race race;
        public Class type;
    }
}
