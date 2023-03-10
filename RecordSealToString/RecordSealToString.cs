namespace RecordSealToString
{
    public record Parent(string FirstName, string LastName)
    {
        public sealed override string ToString()
        {
            return $"Hi my name is: {FirstName} {LastName}";
        }
    }

    public record Child(string FirstName, string LastName, string Phone)
        : Parent(FirstName, LastName)
    {
        //Невозможно оверрайдить при sealed
        public override string ToString()
        {
            return $"Hi my name is: {FirstName} {LastName}. And my Phone is: {Phone}";
        }
    }
}
