using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_E_Automotriz1
{
    public class Permisos
    {
        public Permisos(int id, int fkusuario, bool lectura, bool escritura, bool actualizar, bool eliminar)
        {
            Id = id;
            Fkusuario = fkusuario;
            Lectura = lectura;
            Escritura = escritura;
            Actualizar = actualizar;
            Eliminar = eliminar;
        }

        public int Id { get; set; }
        public int Fkusuario { get; set; }
        public bool Lectura { get; set; }
        public bool Escritura { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
    }
}
