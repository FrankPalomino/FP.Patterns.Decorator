using FP.Patterns.Decorator;

DrinkComponent coffee = new BlackCoffee();
coffee = new Milk(coffee);
coffee = new Sugar(coffee);

Console.WriteLine($"Product {coffee.Description} has a price of: ${coffee.Price}");
Console.ReadLine();