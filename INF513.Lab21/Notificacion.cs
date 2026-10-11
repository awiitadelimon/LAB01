namespace INF513.Lab21;

public abstract class Notificacion
{
    public abstract string Enviar();
}

public class NotificacionEmail : Notificacion
{
    public override string Enviar()
    {
        return "Notificación enviada por correo electrónico.";
    }
}

public class NotificacionSms : Notificacion
{
    public override string Enviar()
    {
        return "Notificación enviada por SMS.";
    }
}