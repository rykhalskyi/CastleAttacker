using System.Collections.Generic;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace CastleAttacker.Models
{
    class Cell
    {
        Dictionary<CellColor, Color> _mapping = new Dictionary<CellColor, Color>()
        {
            {CellColor.Blue, Colors.DodgerBlue},
            {CellColor.Brown, Colors.SaddleBrown},
            {CellColor.Green, Colors.Green},
            {CellColor.Orange, Colors.Orange},
            {CellColor.Red, Colors.Red},
            {CellColor.Violet, Colors.BlueViolet},
            {CellColor.Yellow, Colors.Yellow}
        };

        public CellColor Color { get; }
        public int Damage { get; set; }
        public int Health { get; set; }

        public Brush UiBrush { get; }

        public Cell(CellColor color)
        {
            Color = color;
            UiBrush = new SolidColorBrush(_mapping[color]);
        }
    }
}
