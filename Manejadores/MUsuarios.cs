using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_E_Automotriz1;
using AccesoaDatos;
using Crud;
using System.Windows.Forms;
using System.Drawing;
using System.Data;

namespace Manejadores
{
    public class MUsuarios
    {
        AUsuario a = new AUsuario();
        Grafico g = new Grafico();

        public void Borrar(Usuarios Entidad)
        {
            DialogResult rs = MessageBox.Show(
                string.Format(string.Format(
                    "Está seguro de borrar?: {0}", Entidad.Nombre)
                ), "!Atención",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
                a.Eliminar(Entidad);
        }

        public void Guardar(Usuarios Entidad)
        {
            try
            {
                a.Guardar(Entidad);
                g.MensajeAlerta("Guardado!", "!Atención",
                    MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                g.MensajeAlerta("Favor de revisar", "!Advertencia", MessageBoxIcon.Error);
            }
        }

        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.RowTemplate.Height = 30;
            tabla.DataSource = a.Mostrar().Tables["Usuarios"];
            tabla.Columns.Insert(7, g.Boton("Editar", Color.Green));
            tabla.Columns.Insert(8, g.Boton("Borrar", Color.Red));
            tabla.Rows[tabla.Rows.Count - 1].Height = (int)0.5;
        }
    }
}
