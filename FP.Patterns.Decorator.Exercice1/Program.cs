using FP.Patterns.Decorator.Exercice1;

string text1 = "Hola me llamo Frank";
text1 = new BoldFormatter().Format(text1);
text1 = new ItalicFormatter().Format(text1);
text1 = new ColorFormatter().Format(text1);
text1 = new UnderlineFormatter().Format(text1);

Console.WriteLine(text1);