namespace FP.Patterns.Decorator.Exercice1
{
    public class ColorFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"{text}:Colored";
        }
    }
}
