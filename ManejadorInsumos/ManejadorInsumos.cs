using AccesoDatos;
using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorInsumos
    {
        AccesoInsumos ai = new AccesoInsumos();
        Graficos g = new Graficos();
        public void Agregar(dynamic Entidad)
        {
            ai.Agregar(Entidad);
        }
        public void Eliminar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que deseas borrar este insumo?" +
                ", esto producirá cambios en los resultados finales","¡ATENCIÓN!",MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                ai.Eliminar(Entidad);
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = ai.Mostrar(filtro).Tables["insumos"];
            tabla.Columns[0].Visible = false;
            tabla.Columns[2].Width = 130;
            tabla.Columns[4].Visible = false;
            tabla.Columns.Insert(5,g.Boton("Modificar",Color.PaleGreen));
            tabla.Columns.Insert(6, g.Boton("Borrar", Color.Red));
        }
    }
}
