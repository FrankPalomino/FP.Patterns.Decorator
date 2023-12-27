namespace FP.Patterns.Decorator
{
    internal class Sugar : AddedDecorator
    {
        public Sugar(DrinkComponent drink) : base(drink)
        {
        }

        public override double Price => _drink.Price + 2;

        public override string Description => _drink.Description + ", Sugar";
    }
}
