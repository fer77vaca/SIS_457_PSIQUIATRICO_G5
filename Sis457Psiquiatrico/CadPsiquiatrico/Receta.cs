//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadPsiquiatrico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receta()
        {
            this.Medicamento = new HashSet<Medicamento>();
        }
    
        public int id { get; set; }
        public int idPaciente { get; set; }
        public System.DateTime fechaReceta { get; set; }
        public decimal cantidadPrescrita { get; set; }
        public string instruccionesUso { get; set; }
        public string usuarioRegistro { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public short estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medicamento> Medicamento { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}