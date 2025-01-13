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
    public partial class FrmInsumos : Form
    {
        ManejadorInsumos mi;
        public static Insumos insumos = new Insumos(-1,"",0,0,0);
        public static int columna, fila;
        public FrmInsumos()
        {
            InitializeComponent();
            mi = new ManejadorInsumos();
        }
        void Actualizar()
        {
            mi.Mostrar(dtgInsumos,txtBuscar.Text);
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInsumos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            insumos.Id = -1;
            FrmInsumosAdd owo = new FrmInsumosAdd();
            owo.ShowDialog();
            Actualizar();
        }

        private void dtgInsumos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            insumos.Id = int.Parse(dtgInsumos.Rows[fila].Cells[0].Value.ToString());
            insumos.Nombre = dtgInsumos.Rows[fila].Cells[1].Value.ToString();
            insumos.PrecioUnitario = double.Parse(dtgInsumos.Rows[fila].Cells[2].Value.ToString());
            insumos.Cantidad = int.Parse(dtgInsumos.Rows[fila].Cells[3].Value.ToString());
            switch(columna)
            {
                case 5: {
                        FrmInsumosAdd owo = new FrmInsumosAdd();
                        owo.ShowDialog();
                        Actualizar();
                    } break;
                case 6: {
                        mi.Eliminar(insumos.Id);
                        Actualizar();
                    }break;
            }
        }

        private void dtgInsumos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
