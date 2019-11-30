using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasstleAtacker.Models
{
    public enum DiceType
    {
        Red,
        Yellow,
        Orange,
        Green,
        Blue,
        Violet,
        Brown,
        Trade,       //8,9
        Attack,      //10,11
        Repairment,  //12
    }

    class GameRound
    {
        static Random _random = new Random();

        static DiceType[] _diceTypes = {DiceType.Red, DiceType.Orange, DiceType.Yellow, DiceType.Green,
                                DiceType.Blue, DiceType.Violet, DiceType.Brown,
                                DiceType.Trade, DiceType.Trade, 
                                DiceType.Attack, DiceType.Attack,
                                DiceType.Repairment};

        public static (DiceType, DiceType) Run()
        {
            return (_diceTypes[_random.Next(12)], _diceTypes[_random.Next(12)]);
        }

    }
}
