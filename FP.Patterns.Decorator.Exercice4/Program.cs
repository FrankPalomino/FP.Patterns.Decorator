using FP.Patterns.Decorator.Exercice4;

Notification notification = new BasicNotification();
Decorator smsDecorator = new SMSDecorator(notification);
Decorator emailDecorator = new EmailDecorator(notification);
Decorator fileDecorator = new FileLoggingDecorator(notification);

notification.Notify("Hello world!");
smsDecorator.Notify("Hello world!");
emailDecorator.Notify("Hello world!");
fileDecorator.Notify("Hello world!");