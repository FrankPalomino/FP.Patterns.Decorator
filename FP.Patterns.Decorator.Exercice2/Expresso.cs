namespace FP.Patterns.Decorator.Exercice2
{
    public class Expresso : ICoffeeOrder
    {
        private double _price = 2;
        public double CalculatePrice()
        {
            return _price;
        }
    }
}
