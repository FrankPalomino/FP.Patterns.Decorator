namespace FP.Patterns.Decorator.Exercice3
{
    public class SMSNotification : NotificationDecorator
    {
        public SMSNotification(INotification notification) : base(notification)
        {
        }

        public override void Send(string message)
        {
            base.Send($"SMS send: {message}");
        }
    }
}
