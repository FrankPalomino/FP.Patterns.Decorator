namespace FP.Patterns.Decorator
{
    internal class BlackCoffee : DrinkComponent
    {
        public override double Price => 10;
        public override string Description => "Black Coffee";
    }
}
