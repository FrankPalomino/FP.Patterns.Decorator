namespace FP.Patterns.Decorator.Exercice1
{
    public class BoldFormatter : ITextFormatter
    {
        public string Format(string text)
        {
            return $"{text}:Bolded";
        }
    }
}
