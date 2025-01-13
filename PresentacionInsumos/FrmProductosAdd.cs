using Entidades;
using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionInsumos
{
    public partial class FrmProductosAdd : Form
    {
        ManejadorProductos mp;
        public FrmProductosAdd()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
            if(FrmProductos.productos.Id > 0)
            {
                txtNombre.Text = FrmProductos.productos.Producto;
                txtPrecio.Text = FrmProductos.productos.Costo.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mp.Agregar(new Productos(FrmProductos.productos.Id,txtNombre.Text,double.Parse(txtPrecio.Text)));
            MessageBox.Show("Se guardó el producto con éxito");
            Close();
        }
    }
}
