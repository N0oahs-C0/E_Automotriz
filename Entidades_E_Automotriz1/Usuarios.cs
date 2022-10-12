using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_E_Automotriz1
{
   public class Usuarios
    {
        public Usuarios(int idusuario, string nombre, string apellidoP, string apellidoM, string fdfn, string rFC, string passw)
        {
            Idusuario = idusuario;
            Nombre = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Fdfn = fdfn;
            RFC = rFC;
            Passw = passw;
        }

        public int Idusuario { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Fdfn { get; set; }
        public string RFC { get; set; }
        public string Passw { get; set; }
    }
}
