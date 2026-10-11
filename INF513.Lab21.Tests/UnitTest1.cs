using INF513.Lab21;
using Xunit;

namespace INF513.Lab21.Tests;

public class UnitTest1
{
    [Fact]
    public void NotificacionEmail_DebeEnviarMensajeCorrecto()
    {
        Notificacion notificacion = new NotificacionEmail();

        Assert.Equal(
            "Notificación enviada por correo electrónico.",
            notificacion.Enviar());
    }

    [Fact]
    public void NotificacionSms_DebeEnviarMensajeCorrecto()
    {
        Notificacion notificacion = new NotificacionSms();

        Assert.Equal(
            "Notificación enviada por SMS.",
            notificacion.Enviar());
    }

    [Fact]
    public void Notificaciones_DebenEjecutarComportamientoPolimorfico()
    {
        Notificacion[] notificaciones =
        {
            new NotificacionEmail(),
            new NotificacionSms()
        };

        Assert.Equal(
            "Notificación enviada por correo electrónico.",
            notificaciones[0].Enviar());

        Assert.Equal(
            "Notificación enviada por SMS.",
            notificaciones[1].Enviar());
    }

    [Fact]
    public void Notificacion_DebeSerAbstracta()
    {
        Assert.True(typeof(Notificacion).IsAbstract);
    }
}