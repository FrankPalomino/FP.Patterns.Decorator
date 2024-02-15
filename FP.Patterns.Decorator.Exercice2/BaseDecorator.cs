namespace FP.Patterns.Decorator.Exercice2
{
    public abstract class BaseDecorator : ICoffeeOrder
    {
        public ICoffeeOrder _coffeeOrder;

        protected BaseDecorator(ICoffeeOrder coffeeOrder)
        {
            _coffeeOrder = coffeeOrder;
        }

        public virtual double CalculatePrice()
        {
            return _coffeeOrder.CalculatePrice();
        }
    }
}
