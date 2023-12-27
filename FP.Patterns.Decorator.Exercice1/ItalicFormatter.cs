namespace FP.Patterns.Decorator.Exercice1
{
    public class ItalicFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"{text}:Italicted";
        }
    }
}
