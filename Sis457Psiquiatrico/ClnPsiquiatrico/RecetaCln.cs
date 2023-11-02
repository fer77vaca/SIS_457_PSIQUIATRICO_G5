using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class RecetaCln
    {
        public static int insertar (Receta receta)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                context.Receta.Add(receta);
                context.SaveChanges();
                return receta.id;
            }
        }
        public static int actualizar (Receta receta)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                var existente = context.Receta.Find(receta.id);
                existente.fechaReceta = receta.fechaReceta;
                existente.cantidadPrescrita = receta.cantidadPrescrita;
                existente.instruccionesUso = receta.instruccionesUso;
                existente.usuarioRegistro = receta.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar (int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                var existente = context.Receta.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        // OBTENER POR UN id
        public static Receta get(int id)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.Receta.Find(id);
            }
        }

        // OBTENER TODOS LISTA
        public static List<Receta> listar()
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.Receta.Where(x => x.estado != -1).ToList();
            }
        }

        // OBTENER TODOS CON PROCEDIMIENTO ALMACENADO
        public static List<paRecetaListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities())
            {
                return context.paRecetaListar(parametro).ToList();
            }
        }
    }
}
