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
    public class ManejadorTotal
    {
        AccesoTotal at = new AccesoTotal();
        Graficos g = new Graficos();
        public void AgregarLinea()
        {
            at.Agregar();
        }
        public void Mostrar(DataGridView tabla)
        {
            tabla.Columns.Clear();
            tabla.DataSource = at.Mostrar().Tables["total"];
            tabla.Columns[0].Visible = false;
            tabla.Columns.Insert(6,g.Boton("Eliminar",Color.Red));
        }
    }
}
