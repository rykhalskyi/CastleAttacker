using System.ComponentModel;
using System.Runtime.CompilerServices;
using Windows.UI.Composition;
using CasstleAtacker.Annotations;
using CastleAttacker.Models;
using CasstleAtacker.Models;

namespace CasstleAtacker.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Attack Attack { get; private set; }

        public string MaxNumber { get; set; }
        public string MaxDamage { get; set; }
        public string MaxHealth { get; set; }

        public string FirstDice { get; set; }
        public string SecondDice { get; set; }

        public void StartAttack()
        {
            if (int.TryParse(MaxNumber, out int maxNumber) && maxNumber < 7)
            {
                
                Attack = Attack.StartAttack(maxNumber, GetInt(MaxDamage), GetInt(MaxHealth));
            }
            else
            {
                Attack = Attack.StartAttack();    
            }
            
            OnPropertyChanged(nameof(Attack));
        }

        int GetInt(string str)
        {
            return int.TryParse(str, out int damage) ? damage : 0;
        }

        public void ThrowDices()
        {
            var dices = GameRound.Run();

            FirstDice = dices.Item1;
            SecondDice = dices.Item2;

            OnPropertyChanged(nameof(FirstDice));
            OnPropertyChanged(nameof(SecondDice));
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
