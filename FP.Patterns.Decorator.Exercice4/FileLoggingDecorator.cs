namespace FP.Patterns.Decorator.Exercice4
{
    public class FileLoggingDecorator : Decorator
    {
        public FileLoggingDecorator(Notification component) : base(component)
        {
        }

        public override void Notify(string message)
        {
            base.Notify($"Send to File logging: {message}");
        }
    }
}
