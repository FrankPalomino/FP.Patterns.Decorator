namespace FP.Patterns.Decorator
{
    internal class DecaffeinatedCoffee : DrinkComponent
    {
        public override double Price => 12;
        public override string Description => "Decaffeinated Coffee";
    }
}
