using FP.Patterns.Decorator.Exercice2;

ICoffeeOrder firstOrder = new Expresso();

firstOrder = new Stevia(firstOrder);

Console.WriteLine(firstOrder.CalculatePrice());

firstOrder = new Nata(firstOrder);

Console.WriteLine(firstOrder.CalculatePrice());
