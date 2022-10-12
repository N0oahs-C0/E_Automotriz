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
    public partial class FmrInicioS : Form
    {
        MUsuarios m = new MUsuarios();
        AUsuario a = new AUsuario();
        public static int idUsuario;
        public static string usuario;
        public FmrInicioS()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = a.Inicio(txtUsuario.Text);
                var dt = new DataTable();
                dt = ds.Tables[0];
                idUsuario = int.Parse(dt.Rows[0]["id"].ToString());

                usuario = dt.Rows[0]["nombre"].ToString();
                if (usuario == txtUsuario.Text)
                {
                    MessageBox.Show("Bien hecho" + txtUsuario.Text);
                    FmrMenu frm = new FmrMenu();
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No tiene usted una cuenta registrada");
            }
        }
    }
}
