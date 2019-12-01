using CasstleAtacker.Models.Dices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasstleAtacker.Models
{
    class GameRound
    {
        static Random _random = new Random();
        
        static IDice _firstDice = new ColorDice();
        static IDice _secondDice = new ColorDice();

        public static (string, string) Run()
        {
            var firstDice = _firstDice.Throw(_random.Next(_firstDice.Faces));
            var secondDice = _secondDice.Throw(_random.Next(_secondDice.Faces));

            return (firstDice, secondDice);
        }

    }
}
