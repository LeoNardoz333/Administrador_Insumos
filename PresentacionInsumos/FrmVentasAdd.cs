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
    public partial class FrmVentasAdd : Form
    {
        ManejadorVentas mv;
        AccesoVentas av;
        AccesoTotal at;
        public FrmVentasAdd()
        {
            InitializeComponent();
            mv = new ManejadorVentas();
            av = new AccesoVentas();
            at = new AccesoTotal();
            mv.ExtraerProducto(cmbProducto);
            if (FrmVentas.ventas.Id > 0)
            {
                txtCantidad.Text = FrmVentas.ventas.CantidadVendido.ToString();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            mv.Agregar(new Ventas(FrmVentas.ventas.Id,int.Parse(cmbProducto.SelectedValue.ToString())
                ,int.Parse(txtCantidad.Text)));
            MessageBox.Show("Se ha registrado la venta con éxito");
            Close();
        }

        private void FrmVentasAdd_Load(object sender, EventArgs e)
        {
            if (FrmVentas.ventas.Id < 0)
            {
                var ds = at.Mostrar();
                var dt = new DataTable();
                dt = ds.Tables[0];
                lblSemana.Text = "Semana " + dt.Rows.Count.ToString();
            }
            else if(FrmVentas.ventas.Id > 0)
            {
                var ds = av.Mostrar("");
                var dt = new DataTable();
                dt = ds.Tables[0];
                lblSemana.Text = "Semana " + dt.Rows[FrmVentas.fila]["No. de Semana"].ToString();
            }
        }
    }
}
