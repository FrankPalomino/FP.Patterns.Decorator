namespace FP.Patterns.Decorator.Exercice4
{
    public class BasicNotification : Notification
    {
        public override void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}
