using System;
using System.Collections.Generic;
using CasstleAtacker.Models;

namespace CastleAttacker.Models
{
    class Attack
    {
        private const int DefaultMaxCells = 3;

        public List<Cell> Cells { get; }

        public static Attack StartAttack(int maxCells)
        {
            var random = new Random();

            var cellNumber = random.Next(maxCells)+1;

            var randomColor = new RandomColor(cellNumber);

            var cells = new List<Cell>();
            for (int i = 0; i < cellNumber; i++)
            {
                cells.Add(new Cell(randomColor.GetRandom()));
            }

            return new Attack(cells);
        }

        public static Attack StartAttack()
        {
            return StartAttack(DefaultMaxCells);
        }

        private Attack(List<Cell> cells)
        {
            Cells = cells;
        }
    }
}
