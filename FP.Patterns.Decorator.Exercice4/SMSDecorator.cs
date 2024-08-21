namespace FP.Patterns.Decorator.Exercice4
{
    public class SMSDecorator : Decorator
    {
        public SMSDecorator(Notification component) : base(component)
        {
        }

        public override void Notify(string message)
        {
            base.Notify($"Send to SMS: {message}");
        }
    }
}
