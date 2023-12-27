namespace FP.Patterns.Decorator.Exercice1
{
    public class UnderlineFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"{text}:Underlined";
        }
    }
}
