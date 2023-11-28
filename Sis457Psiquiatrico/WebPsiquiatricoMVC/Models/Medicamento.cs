using System;
using System.Collections.Generic;

namespace WebPsiquiatricoMVC.Models;

public partial class Medicamento
{
    public int Id { get; set; }

    public int IdReceta { get; set; }

    public string NombreMedicamento { get; set; } = null!;

    public string Dosificacion { get; set; } = null!;

    public decimal Precio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Recetum IdRecetaNavigation { get; set; } = null!;
}
