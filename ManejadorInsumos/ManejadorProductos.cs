using AccesoDatos;
using Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorProductos
    {
        AccesoProductos ap = new AccesoProductos();
        Graficos g = new Graficos();
        public void Agregar(dynamic Entidad)
        {
            ap.Agregar(Entidad);
        }
        public void Eliminar(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Seguro que quieres borrar este producto?," +
                " se eliminarán todas las ventas que involucren este producto, y" +
                " habrán cambios en los resultados finales","¡ATENCIÓN!",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(rs==DialogResult.Yes)
            {
                ap.Eliminar(Entidad);
            }
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = ap.Mostrar(filtro).Tables["productos"];
            tabla.Columns[0].Visible = false;
            tabla.Columns[1].Width = 150;
            tabla.Columns.Insert(3,g.Boton("Editar",Color.PaleGreen));
            tabla.Columns.Insert(4, g.Boton("Borrar", Color.Red));
        }
    }
}
