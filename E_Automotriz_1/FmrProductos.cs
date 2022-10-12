using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_E_Automotriz1;
using Manejadores;
using AccesoaDatos;

namespace E_Automotriz_1
{
    public partial class FmrProductos : Form
    {
        MProducto mp;
        public static Producto entidad = new Producto("", "", "", "");
        public static bool[,] permiso = FmrMenu.permisos;
        public static int escritura = 1, actualizar = 1, eliminar = 1, fkusuario = 0;
        public FmrProductos()
        {
            InitializeComponent();
            mp = new MProducto();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
