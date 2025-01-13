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
    public partial class FrmProductos : Form
    {
        ManejadorProductos mp;
        public static Productos productos = new Productos(0,"",0);
        int columna, fila;
        public FrmProductos()
        {
            InitializeComponent();
            mp = new ManejadorProductos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Actualizar()
        {
            mp.Mostrar(dtgProductos,txtBuscar.Text);
        }
        private void FrmProductos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            productos.Id = -1;
            FrmProductosAdd owo = new FrmProductosAdd();
            owo.ShowDialog();
            Actualizar();
        }

        private void dtgProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productos.Id = int.Parse(dtgProductos.Rows[fila].Cells[0].Value.ToString());
            productos.Producto = dtgProductos.Rows[fila].Cells[1].Value.ToString();
            productos.Costo = double.Parse(dtgProductos.Rows[fila].Cells[2].Value.ToString());
            switch(columna)
            {
                case 3: {
                        FrmProductosAdd owo = new FrmProductosAdd();
                        owo.ShowDialog();
                        Actualizar();
                    }break;
                case 4:
                    {
                        mp.Eliminar(productos);
                        Actualizar();
                    }break;
            }
        }

        private void dtgProductos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
