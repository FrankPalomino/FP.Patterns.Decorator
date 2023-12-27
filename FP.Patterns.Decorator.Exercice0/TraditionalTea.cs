namespace FP.Patterns.Decorator
{
    internal class TraditionalTea : DrinkComponent
    {
        public override double Price => 8;
        public override string Description => "Traditional Tea";
    }
}
