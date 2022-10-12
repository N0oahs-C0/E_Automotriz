using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades_E_Automotriz1;
using Crud;
using System.Data;

namespace AccesoaDatos
{
    public class AUsuario
    {
        Base b = new Base("localhost", "root", "", "Automotriz", 3306);
        public void Eliminar(Usuarios entidad)
        {
            b.Comando(string.Format("Delete from usuarios where codigobarras={0}", entidad.Idusuario));
        }
        public void Guardar(Usuarios entidad)
        {
            b.Comando(string.Format("CALL insertusuario({0},'{1}','{2}','{3}','{4}','{5}','{6}');",
                entidad.Idusuario, entidad.Nombre, entidad.ApellidoP, entidad.ApellidoM, entidad.Fdfn,entidad.RFC,entidad.Passw));
        }
        public void Actualizar(Usuarios entidad)
        {
            b.Comando(string.Format("CALL updateusuario({0},'{1}','{2}','{3}','{4}','{5}','{6}');",
                entidad.Idusuario, entidad.Nombre, entidad.ApellidoP, entidad.ApellidoM, entidad.Fdfn, entidad.RFC, entidad.Passw));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("Select * from Usuarios"), "Usuarios");
        }
    }
}
