﻿using EllipticCurve.Utils;

namespace DentallApp.Features.Appoinments.AvailabilityHours;

public class AvailabilityOptions
{
    /// <summary>
    /// Obtiene o establece la hora de trabajo de inicio del odontólogo.
    /// </summary>
    public TimeSpan DentistStartHour { get; set; }

    /// <summary>
    /// Obtiene o establece la hora de trabajo de finalización del odontólogo.
    /// </summary>
    public TimeSpan DentistEndHour { get; set; }

    /// <summary>
    /// Obtiene o establece el tiempo de duración de un servicio dental (debe estar expresado en minutos).
    /// </summary>
    public TimeSpan ServiceDuration { get; set; }

    /// <summary>
    /// Obtiene o establece una colección con los rangos de tiempos no disponibles.
    /// La colección debe estar ordenada de forma ascendente.
    /// </summary>
    public List<UnavailableTimeRange> Unavailables { get; set; }
}
