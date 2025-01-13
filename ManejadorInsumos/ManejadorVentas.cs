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
    public class ManejadorVentas
    {
        AccesoVentas av = new AccesoVentas();
        AccesoProductos ap = new AccesoProductos();
        Graficos g = new Graficos();
        public void Agregar(dynamic Entidad)
        {
            av.Agregar(Entidad);
        }
        public void Borrar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que quieres borrar esta venta?, " +
                "esto provocará cambios en los resultados finales", "¡ATENCIÓN!", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                av.Eliminar(Entidad);
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = av.Mostrar(filtro).Tables["ventas"];
            tabla.Columns[0].Visible = false;
            tabla.Columns[2].Visible = false;
            tabla.Columns[3].Width = 150;
            tabla.Columns.Insert(6,g.Boton("Modificar",Color.PaleGreen));
            tabla.Columns.Insert(7, g.Boton("Eliminar", Color.Red));
        }
        public void ExtraerProducto(ComboBox caja)
        {
            caja.DataSource = ap.Mostrar("").Tables["productos"];
            caja.ValueMember = "id";
            caja.DisplayMember = "producto";
        }
    }
}
