using FP.Patterns.Decorator.Exercice3;

// Create basic notification
INotification notification = new BasicNotification();

// Decorate with SMS notification
notification = new SMSNotification(notification);

// Decorate with Email notification
notification = new EmailNotification(notification);

// Decorate with Push notification
notification = new PushNotification(notification);

// Send the notification with all the decorators applied
notification.Send("Hello, this is a test notification!");

Console.ReadLine(); // Keep console window open