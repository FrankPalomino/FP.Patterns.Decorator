namespace FP.Patterns.Decorator.Exercice2
{
    public class Cappuccino : ICoffeeOrder
    {
        private double _price = 1;

        public double CalculatePrice()
        {
            return _price;
        }
    }
}
