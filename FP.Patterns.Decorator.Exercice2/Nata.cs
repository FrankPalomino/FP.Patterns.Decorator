namespace FP.Patterns.Decorator.Exercice2
{
    public class Nata : BaseDecorator
    {
        private readonly double _price = 1.5;
        public Nata(ICoffeeOrder coffeeOrder) : base(coffeeOrder)
        {
        }

        public override double CalculatePrice()
        {
            return _price + _coffeeOrder.CalculatePrice();
        }
    }
}
