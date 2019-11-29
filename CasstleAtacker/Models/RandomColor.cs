using System;
using System.Collections.Generic;
using CastleAttacker.Models;

namespace CasstleAtacker.Models
{
    class RandomColor
    {
        private const int MaxColor = 7;

        List<CellColor> _availibleColors = new List<CellColor>();
        Random _random = new Random();

        int _number;
        int _iteration = 0;

        public RandomColor(int number)
        {
            if (number > MaxColor)
                throw new ArgumentException("Cell number should be less or equals 7");

            _number = number;
        }

        public CellColor GetRandom()
        {
            if (_iteration == _number)
                throw new InvalidOperationException("Already generated");

            _iteration++;

            CellColor color;
            do
            {
               color = (CellColor)_random.Next(MaxColor);
            } while (_availibleColors.Contains(color));

            _availibleColors.Add(color);

            return color;
        }
    }
}
