namespace FP.Patterns.Decorator.Exercice2
{
    public class Stevia : BaseDecorator
    {
        private readonly double _price = 0.5;
        public Stevia(ICoffeeOrder coffeeOrder) : base(coffeeOrder)
        {
        }

        public override double CalculatePrice()
        {
            return _price + _coffeeOrder.CalculatePrice();
        }
    }
}
