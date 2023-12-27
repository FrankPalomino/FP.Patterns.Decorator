namespace FP.Patterns.Decorator
{
    internal abstract class DrinkComponent
    {
        public abstract double Price { get; }
        public abstract string Description { get; }
    }
}
