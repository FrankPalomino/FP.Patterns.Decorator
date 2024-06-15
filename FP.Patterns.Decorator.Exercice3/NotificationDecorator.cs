namespace FP.Patterns.Decorator.Exercice3
{
    public class NotificationDecorator : INotification
    {
        private readonly INotification _notification;

        public NotificationDecorator(INotification notification)
        {
            _notification = notification;
        }

        public virtual void Send(string message)
        {
            _notification.Send(message);
        }
    }
}
