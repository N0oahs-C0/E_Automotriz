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
    public class APermisos
    {
        Base b = new Base("localhost", "root", "", "Automotriz", 3306);
        public void Eliminar(Permisos entidad)
        {
            b.Comando(string.Format("Delete from prmisos where codigobarras={0}", entidad.Id));
        }
        public void Guardar(Permisos entidad)
        {
            b.Comando(string.Format("CALL insertpermisos({0},{1},{2},{3},{4},{5});",
                entidad.Id, entidad.Fkusuario, entidad.Lectura, entidad.Escritura,entidad.Actualizar, entidad.Eliminar));
        }
        public void Actualizar(Permisos entidad)
        {
            b.Comando(string.Format("CALL updatepermisos({0},{1},{2},{3},{4},{5});",
                entidad.Id, entidad.Fkusuario, entidad.Lectura, entidad.Escritura, entidad.Actualizar, entidad.Eliminar));
        }
        public DataSet Mostrar(int id)
        {
            return b.Obtener(string.Format("Select * from Permisos where fkidusuario={0}",id), "Permisos");
        }

 
    
    }
}
