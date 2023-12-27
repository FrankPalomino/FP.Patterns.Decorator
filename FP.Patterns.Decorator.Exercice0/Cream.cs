namespace FP.Patterns.Decorator
{
    internal class Cream : AddedDecorator
    {
        public Cream(DrinkComponent drink) : base(drink)
        {
        }

        public override double Price => _drink.Price + 5;

        public override string Description => _drink.Description + ", Cream";
    }
}
