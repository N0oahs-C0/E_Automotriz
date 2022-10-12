using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_E_Automotriz1
{
    public class Producto
    {
        public Producto(string codigobarras, string nombre, string descrpcion, string marca)
        {
            Codigobarras = codigobarras;
            Nombre = nombre;
            Descrpcion = descrpcion;
            Marca = marca;
        }

        public string Codigobarras { get; set; }
        public string Nombre { get; set; }
        public string Descrpcion { get; set; }
        public string Marca { get; set; }
    }
}
