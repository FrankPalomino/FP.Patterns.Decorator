using System.Transactions;

namespace FP.Patterns.Decorator.Exercice4
{
    public class EmailDecorator : Decorator
    {
        public EmailDecorator(Notification component) : base(component)
        {
        }

        public override void Notify(string message)
        {
            base.Notify($"Send to Email: {message}");
        }
    }
}
