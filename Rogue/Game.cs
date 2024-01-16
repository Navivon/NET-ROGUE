using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rogue
{
    internal class Game
    {
        public string LineReader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string input = Console.ReadLine();
            return input;
        }
        public void Run()
        {

            PlayerCharacter player = new PlayerCharacter();
            Console.WriteLine("Valitse nimi: ");
            player.name = LineReader();

            Console.WriteLine("Valitse rotu:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 = Ihminen \n 2 = Elf \n 3 = Orc");
            switch (LineReader())
            {
                case "1":
                    player.race = Race.Human;
                    break;
                case "2":
                    player.race = Race.Elf;
                    break;
                case "3":
                    player.race = Race.Orc;
                    break;
            }

            Console.WriteLine("Valitse tyyppi:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1 = Meele \n 2 = Range");
            switch (LineReader())
            {
                case "1":
                    player.type = Class.Meele;
                    break;
                case "2":
                    player.type = Class.Range;
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Pelajaan tiedot: \n Nimi on {player.name} \n Tyyppi on {player.type} \n Rotu on {player.race}");
        }
    }
}
