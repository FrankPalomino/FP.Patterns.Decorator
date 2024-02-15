namespace FP.Patterns.Decorator.Exercice2
{
    public class Latte : ICoffeeOrder
    {
        private double _price = 3;
        public double CalculatePrice()
        {
            return _price;
        }
    }
}
