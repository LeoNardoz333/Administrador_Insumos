using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorBorrar
    {
        AccesoBorrar ab = new AccesoBorrar();
        public void BorrarTodo()
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que quieres borrar todos los registros de todas las tablas?",
                "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                MessageBox.Show("Esto puede demorar unos minutos...");
                ab.BorrarTodo();
                MessageBox.Show("Se han borrado todos los registros");
            }
        }
        public void BorrarTotal(dynamic Entidad)
        {
            DialogResult rs = MessageBox.Show("¿Estás seguro que quieres borrar los registros de esta semana?",
                "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                ab.BorrarTotal(Entidad);
            }
        }
    }
}
