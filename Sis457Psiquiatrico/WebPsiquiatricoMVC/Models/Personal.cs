using System;
using System.Collections.Generic;

namespace WebPsiquiatricoMVC.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string CedulaIdentidad { get; set; } = null!;

    public string? Especialidad { get; set; }

    public string? Telefono { get; set; }

    public string HorarioTrabajo { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
