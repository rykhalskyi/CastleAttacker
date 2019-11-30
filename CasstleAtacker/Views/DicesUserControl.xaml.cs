using System;
using CasstleAtacker.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CasstleAtacker.Views
{
    public sealed partial class DicesUserControl : UserControl
    {
        public DicesUserControl()
        {
            this.InitializeComponent();
        }

        public DiceType FirstDice
        {
            get { return (DiceType)GetValue(FirstDiceProperty); }
            set { SetValue(FirstDiceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FirstDice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstDiceProperty =
            DependencyProperty.Register("FirstDice", typeof(DiceType), typeof(DicesUserControl), new PropertyMetadata(0, OnFirstDiceSet));

        private static void OnFirstDiceSet(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public DiceType SecondDice
        {
            get { return (DiceType)GetValue(SecondDiceProperty); }
            set { SetValue(SecondDiceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SecondDice.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SecondDiceProperty =
            DependencyProperty.Register("SecondDice", typeof(DiceType), typeof(DicesUserControl), new PropertyMetadata(0, OnSecondDiceSet));

        private static void OnSecondDiceSet(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            throw new NotImplementedException();
        }


    }
}
