using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class PersonalCln
    {
        public static int insertar (Personal personal)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                context.Personal.Add(personal);
                context.SaveChanges();
                return personal.id;
            }
        }
        public static int actualizar(Personal personal)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Personal.Find(personal.id);
                existente.nombre = personal.nombre;
                existente.cedulaIdentidad = personal.cedulaIdentidad;
                existente.especialidad = personal.especialidad;
                existente.telefono = personal.telefono;
                existente.horarioTrabajo = personal.horarioTrabajo;
                existente.usuarioRegistro = personal.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Personal.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        // OBTENER POR UN id
        public static Personal get(int id)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Personal.Find(id);
            }
        }

        // OBTENER TODOS LISTA
        public static List<Personal> listar()
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Personal.Where(x => x.estado != -1).ToList();
            }
        }

        // OBTENER TODOS CON PROCEDIMIENTO ALMACENADO
        public static List<paPersonalListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.paPersonalListar(parametro).ToList();
            }
        }
    }
}
