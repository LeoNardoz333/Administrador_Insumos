using AccesoDatos;
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
    public partial class FrmInsumosAdd : Form
    {
        ManejadorInsumos mi;
        AccesoInsumos ai;
        AccesoTotal at;
        public FrmInsumosAdd()
        {
            InitializeComponent();
            mi = new ManejadorInsumos();
            ai = new AccesoInsumos();
            at = new AccesoTotal();
            if (FrmInsumos.insumos.Id > 0)
            {
                txtNombre.Text = FrmInsumos.insumos.Nombre;
                txtPrecio.Text = FrmInsumos.insumos.PrecioUnitario.ToString();
                txtCantidad.Text = FrmInsumos.insumos.Cantidad.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mi.Agregar(new Insumos(FrmInsumos.insumos.Id, txtNombre.Text, double.Parse(txtPrecio.Text),
                int.Parse(txtCantidad.Text), 0));
            MessageBox.Show("Se guardó el insumo con éxito");
            Close();
        }

        private void FrmInsumosAdd_Load(object sender, EventArgs e)
        {
            if (FrmInsumos.insumos.Id < 0)
            {
                var ds = at.Mostrar();
                var dt = new DataTable();
                dt = ds.Tables[0];
                lblSemana.Text = "Semana " + dt.Rows.Count.ToString();
            }
            else if (FrmInsumos.insumos.Id > 0)
            {
                var ds = ai.Mostrar("");
                var dt = new DataTable();
                dt = ds.Tables[0];
                lblSemana.Text = "Semana " + dt.Rows[FrmInsumos.fila]["noSemana"].ToString();
            }
        }
    }
}
