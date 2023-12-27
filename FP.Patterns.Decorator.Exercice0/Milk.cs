namespace FP.Patterns.Decorator
{
    internal class Milk : AddedDecorator
    {
        public Milk(DrinkComponent drink) : base(drink)
        {
        }

        public override double Price => _drink.Price + 5;

        public override string Description => _drink.Description + ", Milk";
    }
}
