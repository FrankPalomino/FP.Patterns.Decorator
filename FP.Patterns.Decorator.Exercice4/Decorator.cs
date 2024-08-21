namespace FP.Patterns.Decorator.Exercice4
{
    public abstract class Decorator : Notification
    {
        private readonly Notification _component;

        protected Decorator(Notification component)
        {
            _component = component;
        }

        public override void Notify(string message)
        {
            _component.Notify(message);
        }
    }
}
