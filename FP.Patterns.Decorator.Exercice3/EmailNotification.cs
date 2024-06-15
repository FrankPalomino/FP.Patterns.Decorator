namespace FP.Patterns.Decorator.Exercice3
{
    public class EmailNotification : NotificationDecorator
    {
        public EmailNotification(INotification notification) : base(notification)
        {
        }

        public override void Send(string message)
        {
            base.Send($"Email send: {message}");
        }
    }
}
