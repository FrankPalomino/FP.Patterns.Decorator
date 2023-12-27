namespace FP.Patterns.Decorator
{
    internal abstract class AddedDecorator : DrinkComponent
    {
        protected DrinkComponent _drink;

        public AddedDecorator(DrinkComponent drink)
        {
            _drink = drink;
        }
    }
}
