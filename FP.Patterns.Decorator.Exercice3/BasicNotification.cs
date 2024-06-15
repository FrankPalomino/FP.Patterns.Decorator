namespace FP.Patterns.Decorator.Exercice3
{
    public class BasicNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Basic Notification: {message}");
        }
    }
}
