namespace CasstleAtacker.Models.Dices
{
    interface IDice
    {
        int Faces { get; }
        string Throw(int number);
    }
}
