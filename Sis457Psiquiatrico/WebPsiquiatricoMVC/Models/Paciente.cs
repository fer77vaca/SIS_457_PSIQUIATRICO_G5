using System;
using System.Collections.Generic;

namespace WebPsiquiatricoMVC.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public int IdPersonal { get; set; }

    public string Nombre { get; set; } = null!;

    public string CedulaIdentidad { get; set; } = null!;

    public int Edad { get; set; }

    public string? Telefono { get; set; }

    public string HistorialMedico { get; set; } = null!;

    public string? Tratamiento { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public DateTime FechaAdmision { get; set; }

    public virtual ICollection<Citum> Cita { get; set; } = new List<Citum>();

    public virtual Personal IdPersonalNavigation { get; set; } = null!;

    public virtual ICollection<Recetum> Receta { get; set; } = new List<Recetum>();
}
