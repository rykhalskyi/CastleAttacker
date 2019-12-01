using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CasstleAtacker.Views
{
    public sealed partial class DiceUserControl : UserControl
    {
        public DiceUserControl()
        {
            this.InitializeComponent();
        }
               
        public string Dice
        {
            get { return (string)GetValue(DiceProperty); }
            set { SetValue(DiceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DiceProperty =
            DependencyProperty.Register("Dice", typeof(string), typeof(DiceUserControl), new PropertyMetadata(0, OnThrow));

        private static void OnThrow(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is DiceUserControl control)
            {
                control.FirstDiceText.Text = e.NewValue.ToString();
            }
        }
    }
}
