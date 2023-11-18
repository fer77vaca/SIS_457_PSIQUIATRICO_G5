using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class CitaCln
    {
        public static int insertar(Cita cita)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                context.Cita.Add(cita);
                context.SaveChanges();
                return cita.id;
            }
        }
        public static int actualizar (Cita cita)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Cita.Find (cita.id);
                //existente.idPaciente = cita.idPaciente;
                existente.motivo = cita.motivo;
                existente.fechaReservacion = cita.fechaReservacion;
                existente.pago = cita.pago;
                existente.usuarioRegistro = cita.usuarioRegistro;
                return context.SaveChanges ();
            }
        }
        public static int eliminar (int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Cita.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges ();
            }
        }
        public static Cita get (int id)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Cita.Find (id);
            }
        }
        public static List<Cita> listar()
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Cita.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paCitaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.paCitaListar(parametro).ToList();
            }
        }
    }
}
