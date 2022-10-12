using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_E_Automotriz1
{
    public class Herramienta
    {
        public Herramienta(string codigoherramienta, string nombre, string medida, string marca, string descipcion)
        {
            Codigoherramienta = codigoherramienta;
            Nombre = nombre;
            Medida = medida;
            Marca = marca;
            Descipcion = descipcion;
        }

        public string Codigoherramienta { get; set; }
        public string Nombre { get; set; }
        public string Medida { get; set; }
        public string Marca { get; set; }
        public string Descipcion { get; set; }
    }
}
