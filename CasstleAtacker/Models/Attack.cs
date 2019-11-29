using System;
using System.Collections.Generic;
using CasstleAtacker.Models;

namespace CastleAttacker.Models
{
    class Attack
    {
        private const int DefaultMaxCells = 3;
        private const int DefaultMaxDamage = 12;
        private const int DefaultMaxHealth = 12;

        public List<Cell> Cells { get; }

        public static Attack StartAttack(int maxCells, int maxDamage, int maxHealth)
        {
            var random = new Random();

            var cellNumber = random.Next(maxCells)+1;
            var randomColor = new RandomColor(cellNumber);
            var damage = maxDamage == 0 ? DefaultMaxDamage : maxDamage;
            var health = maxHealth== 0 ? DefaultMaxDamage : maxDamage;

            var cells = new List<Cell>();
            for (int i = 0; i < cellNumber; i++)
            {
                cells.Add(new Cell(randomColor.GetRandom())
                {
                    Damage = random.Next(damage)+1,
                    Health = random.Next(health)+1
                });
            }

            return new Attack(cells);
        }

        public static Attack StartAttack()
        {
            return StartAttack(DefaultMaxCells, DefaultMaxDamage, DefaultMaxHealth);
        }

        private Attack(List<Cell> cells)
        {
            Cells = cells;
        }
    }
}
