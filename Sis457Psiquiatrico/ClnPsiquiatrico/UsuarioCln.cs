using CadPsiquiatrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnPsiquiatrico
{
    public class UsuarioCln
    {
        public static Usuario validar (string usuario, string clave)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Usuario
                    .Where(x => x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
        public static int insertar(Usuario usuario)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }
        public static int actualizar(Usuario usuario)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Usuario.Find(usuario.id);
                existente.usuario1 = usuario.usuario1;
                existente.clave = usuario.clave;
                existente.usuarioRegistro = usuario.usuarioRegistro;
                return context.SaveChanges();
            }
        }
        public static int eliminar(int id, string usuarioRegistro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                var existente = context.Usuario.Find(id);
                existente.estado = -1;
                existente.usuarioRegistro = usuarioRegistro;
                return context.SaveChanges();
            }
        }

        // OBTENER POR UN id
        public static Usuario get(int id)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Usuario.Find(id);
            }
        }

        // OBTENER TODOS LISTA
        public static List<Usuario> listar()
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.Usuario.Where(x => x.estado != -1).ToList();
            }
        }

        // OBTENER TODOS CON PROCEDIMIENTO ALMACENADO
        public static List<paUsuarioListar_Result> listarPa(string parametro)
        {
            using (var context = new LabPsiquiatricoEntities1())
            {
                return context.paUsuarioListar(parametro).ToList();
            }
        }
    }
}
