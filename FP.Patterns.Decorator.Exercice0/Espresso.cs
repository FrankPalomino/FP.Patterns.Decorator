namespace FP.Patterns.Decorator
{
    internal class Espresso : DrinkComponent
    {
        public override double Price => 15;
        public override string Description => "Espresso";
    }
}
