using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class PacienteCln
    {
        public static int insertar (Paciente paciente)
        {
            using (var context = new LabPsiquiatricoEntities1 ())
            {
                context.Paciente.Add(paciente);
                context.SaveChanges ();
                return paciente.id;
            }
        }
        public static int actualizar (Paciente paciente)
        {
            using (var context = new LabPsiquiatricoEntities1 ())
            {
                var existente = context.Paciente.Find (paciente.id);
                ///existente.idPersonal = paciente.idPersonal;
                existente.nombre = paciente.nombre;
                existente.cedulaIdentidad = paciente.cedulaIdentidad;
                existente.edad = paciente.edad;
                existente.telefono = paciente.telefono;
                existente.historialMedico = paciente.historialMedico;
                existente.fechaAdmision = paciente.fechaAdmision;
                existente.tratamiento = paciente.tratamiento;
                existente.usuarioRegistro = paciente.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Paciente.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static Paciente get(int id)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Paciente.Find(id);
            }
        }
        public static List<Paciente> listar()
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Paciente.Where(x => x.estado != -1).ToList();
            }
        }
        public static List<paPacienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.paPacienteListar(parametro).ToList();
            }
        }
    }
}
