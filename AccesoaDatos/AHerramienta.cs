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
    public class AHerramienta
    {
        Base b = new Base("localhost", "root", "", "Automotriz", 3306);
        public void Eliminar(Herramienta entidad)
        {
            b.Comando(string.Format("Delete from herramientas where codigobarras={0}", entidad.Codigoherramienta));
        }
        public void Guardar(Herramienta entidad)
        {
            b.Comando(string.Format("CALL insertHerramienta('{0}','{1}','{2}','{3}','{4}');",
                entidad.Codigoherramienta, entidad.Nombre, entidad.Medida, entidad.Marca,entidad.Descipcion));
        }
        public void Actualizar(Herramienta entidad)
        {
            b.Comando(string.Format("CALL updateHerramienta('{0}','{1}','{2}','{3}','{4}');",
                entidad.Codigoherramienta, entidad.Nombre, entidad.Medida, entidad.Marca, entidad.Descipcion));
        }
        public DataSet Mostrar()
        {
            return b.Obtener(string.Format("Select * from Herramientas"), "Herramientas");
        }
    }
}
