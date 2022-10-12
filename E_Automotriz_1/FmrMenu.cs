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
    public partial class FmrMenu : Form
    {
        APermisos a = new APermisos();
        MPermisos m = new MPermisos();
        public static int lectura = 0, escritura = 1, actualizar = 2, eliminar = 3;
        public static bool permisoMostrar;

        public static bool[,] permisos = new bool[2, 4];


        public FmrMenu()
        {
            InitializeComponent();
        }
        private void FmrMenu_Load(object sender, EventArgs e)
        {
            List<string> modulos = new List<string>();
            //modulos:
            modulos.Add("Producto");
            modulos.Add("Herramientas");

            var ds = a.Mostrar(FmrInicioS.idUsuario);
            var dt = new DataTable();
            dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                permisos[i, lectura] = bool.Parse(dt.Rows[i]["lectura"].ToString());
                permisos[i, escritura] = bool.Parse(dt.Rows[i]["escritura"].ToString());
                permisos[i, actualizar] = bool.Parse(dt.Rows[i]["actualizar"].ToString());
                permisos[i, eliminar] = bool.Parse(dt.Rows[i]["eliminar"].ToString());
            }
        }
        private void producto_Click(object sender, EventArgs e)
        {
            if (permisos[0, lectura] == false)
                MessageBox.Show("No tienes permisos");
            else
            {
                FmrProductos frm = new FmrProductos();
                frm.Show();
            }

        }
        private void herramientas_Click(object sender, EventArgs e)
        {
                if (permisos[1, lectura] == false)
                    MessageBox.Show("No tienes permisos");
                else
                {
                    FmrHerramienta frs = new FmrHerramienta();
                    frs.Show();
                }

        }
    }
}
