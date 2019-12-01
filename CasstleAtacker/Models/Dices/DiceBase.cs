using System;

namespace CasstleAtacker.Models.Dices
{
    abstract class DiceBase : IDice
    {
        public DiceBase(string[] dices)
        {
            _dices = dices;
        }

        string[] _dices;

        public int Faces => _dices.Length;

        public string Throw(int number)
        {
            return _dices[number];
        }
    }
}
