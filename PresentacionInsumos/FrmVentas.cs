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
    public partial class FrmVentas : Form
    {
        ManejadorVentas mv;
        public static Ventas ventas = new Ventas(0,0,0);
        public static int columna, fila;
        public FrmVentas()
        {
            InitializeComponent();
            mv = new ManejadorVentas();
        }
        void Actualizar()
        {
            mv.Mostrar(dtgVentas,txtBuscar.Text);
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ventas.Id = int.Parse(dtgVentas.Rows[fila].Cells[0].Value.ToString());
            ventas._Idproducto = int.Parse(dtgVentas.Rows[fila].Cells[2].Value.ToString());
            ventas.CantidadVendido = int.Parse(dtgVentas.Rows[fila].Cells[5].Value.ToString());
            switch(columna)
            {
                case 6: {
                        FrmVentasAdd owo = new FrmVentasAdd();
                        owo.ShowDialog();
                        Actualizar();
                    }break;
                case 7:
                    {
                        mv.Borrar(ventas);
                        Actualizar();
                    }break;
            }
        }

        private void dtgVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ventas.Id = -1;
            FrmVentasAdd uwu = new FrmVentasAdd();
            uwu.ShowDialog();
            Actualizar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
