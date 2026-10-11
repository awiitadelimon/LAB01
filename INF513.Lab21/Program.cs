using INF513.Lab21;

Notificacion notificacionEmail = new NotificacionEmail();
Notificacion notificacionSms = new NotificacionSms();

Console.WriteLine(notificacionEmail.Enviar());
Console.WriteLine(notificacionSms.Enviar());