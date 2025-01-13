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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optInsumos_Click(object sender, EventArgs e)
        {
            FrmInsumos owo = new FrmInsumos();
            owo.ShowDialog();
        }

        private void optProductos_Click(object sender, EventArgs e)
        {
            FrmProductos uwu = new FrmProductos();
            uwu.ShowDialog();
        }

        private void optVentas_Click(object sender, EventArgs e)
        {
            FrmVentas owo = new FrmVentas();
            owo.ShowDialog();
        }

        private void optResultados_Click(object sender, EventArgs e)
        {
            FrmTotal total = new FrmTotal();
            total.ShowDialog();
        }
    }
}
