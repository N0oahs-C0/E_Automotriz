using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using Entidades_E_Automotriz1;

namespace AccesoaDatos
{
    public class AProducto
    {
        Base b = new Base("localhost", "root", "", "Automotriz",3306);
        public void Eliminar(Producto entidad)
        {
            b.Comando(string.Format("Delete from producto where codigobarras={0}",entidad.Codigobarras));
        }
        public void Guardar(Producto entidad)
        {
            b.Comando(string.Format("CALL insertproducto('{0}','{1}','{2}','{3}');",
                entidad.Codigobarras, entidad.Nombre, entidad.Descrpcion, entidad.Marca));
        }
        public void Actualizar(Producto entidad)
        {
            b.Comando(string.Format("CALL updateproducto('{0}','{1}','{2}','{3}');",
               entidad.Codigobarras, entidad.Nombre, entidad.Descrpcion, entidad.Marca));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("Select * from Producto"), "Producto");
        }
    }
}
