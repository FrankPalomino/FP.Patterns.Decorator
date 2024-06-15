namespace FP.Patterns.Decorator.Exercice3
{
    public class PushNotification : NotificationDecorator
    {
        public PushNotification(INotification notification) : base(notification)
        {
        }

        public override void Send(string message)
        {
            base.Send($"Push send: {message}");
        }
    }
}
