using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class PacienteCln
    {
        public static int insertar (Paciente paciente)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                context.Paciente.Add (paciente);
                context.SaveChanges();
                return paciente.id;
            }
        }
        public static int actualizar (Paciente paciente)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                var existente = context.Paciente.Find(paciente.id);
                existente.nombre = paciente.nombre;
                existente.apellido = paciente.apellido;
                existente.cedulaIdentidad = paciente.cedulaIdentidad;
                existente.razonSocial = paciente.razonSocial;
                existente.fechaNacimiento = paciente.fechaNacimiento;
                existente.edad = paciente.edad;
                existente.genero = paciente.genero;
                existente.direccion = paciente.direccion;
                existente.telefono = paciente.telefono;
                existente.historialMedico = paciente.historialMedico;
                existente.fechaAdmision = paciente.fechaAdmision;
                existente.fechaAlta = paciente.fechaAlta;
                existente.tratamiento = paciente.tratamiento;
                existente.usuarioRegistro = paciente.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                var existente = context.Paciente.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        // OBTENER POR UN id
        public static Paciente get(int id)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.Paciente.Find(id);
            }
        }

        // OBTENER TODOS LISTA
        public static List<Paciente> listar()
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.Paciente.Where(x => x.estado != -1).ToList();
            }
        }

        // OBTENER TODOS CON PROCEDIMIENTO ALMACENADO
        public static List<paPacienteListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.paPacienteListar(parametro).ToList();
            }
        }
    }
}
