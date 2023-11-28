using System;
using System.Collections.Generic;

namespace WebPsiquiatricoMVC.Models;

public partial class Citum
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public string Motivo { get; set; } = null!;

    public DateTime FechaReservacion { get; set; }

    public decimal Pago { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;
}
