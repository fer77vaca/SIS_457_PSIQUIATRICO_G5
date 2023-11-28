using System;
using System.Collections.Generic;

namespace WebPsiquiatricoMVC.Models;

public partial class Recetum
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public DateTime FechaReceta { get; set; }

    public decimal CantidadPrescrita { get; set; }

    public string InstruccionesUso { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual ICollection<Medicamento> Medicamentos { get; set; } = new List<Medicamento>();
}
