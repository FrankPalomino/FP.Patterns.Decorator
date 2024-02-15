namespace FP.Patterns.Decorator.Exercice2
{
    public class Sugar : BaseDecorator
    {
        private readonly double _price = 2;
        public Sugar(ICoffeeOrder coffeeOrder) : base(coffeeOrder)
        {
        }

        public override double CalculatePrice()
        {
            return _price + _coffeeOrder.CalculatePrice();
        }
    }
}
