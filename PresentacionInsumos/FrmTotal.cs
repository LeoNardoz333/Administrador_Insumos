using Entidades;
using Manejador;
using System;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;
using AccesoDatos;

namespace PresentacionInsumos
{
    public partial class FrmTotal : Form
    {
        ManejadorTotal mt;
        ManejadorSemana ms;
        ManejadorBorrar mb;
        AccesoTotal at;
        int columna, fila;
        public static Total total = new Total(0);
        public FrmTotal()
        {
            InitializeComponent();
            mt = new ManejadorTotal();
            ms = new ManejadorSemana();
            mb = new ManejadorBorrar();
            at = new AccesoTotal();
        }
        public void CrearPdf()
        {
            FileStream fs = new FileStream(@"C:\Users\Leo J\Documents\Registros\Registros.pdf",FileMode.OpenOrCreate);
            Document documento = new Document(PageSize.A4);
            PdfWriter pw = PdfWriter.GetInstance(documento, fs);
            documento.Open();
            Paragraph titulo = new Paragraph();
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Font = FontFactory.GetFont("Arial", 16);
            titulo.Add("Reporte de resultados");
            documento.Add(titulo);

            /*iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance
(@"C:\OneDrive\Documentos\Escuela\Base de datos\Taller de base de datos\Códigos\PresentaciónAjedrez\PresentaciónAjedrez\Resources\descarga (1).jpg");
            logo.SetAbsolutePosition(470, 725);
            logo.ScaleAbsolute(104, 122);
            documento.Add(logo);
            documento.Add(Chunk.NEWLINE);*/

            #region tabla
            PdfPTable tabla = new PdfPTable(5);
            tabla.WidthPercentage = 100;
            PdfPCell ganancias = new PdfPCell(new Phrase("Ganancias totales"));
            ganancias.BorderWidth = 0;
            ganancias.BorderWidthBottom = 0.75f;
            PdfPCell gastosInsumos = new PdfPCell(new Phrase("Gastos en insumos"));
            gastosInsumos.BorderWidth = 0;
            gastosInsumos.BorderWidthBottom = 0.75f;
            PdfPCell ganVentas = new PdfPCell(new Phrase("Ganancias en ventas"));
            ganVentas.BorderWidth = 0;
            ganVentas.BorderWidthBottom = 0.75f;
            PdfPCell canVendidos = new PdfPCell(new Phrase("Cantidad de vendidos"));
            canVendidos.BorderWidth = 0;
            canVendidos.BorderWidthBottom = 0.75f;
            PdfPCell Semana = new PdfPCell(new Phrase("Número de semana"));
            Semana.BorderWidth = 0;
            Semana.BorderWidthBottom = 0.75f;
            tabla.AddCell(ganancias);
            tabla.AddCell(gastosInsumos);
            tabla.AddCell(ganVentas);
            tabla.AddCell(canVendidos);
            tabla.AddCell(Semana);

            var ds = at.Mostrar();
            var dt = new System.Data.DataTable();
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                ganancias = new PdfPCell(new Phrase(row["Ganancias totales"].ToString()));
                gastosInsumos = new PdfPCell(new Phrase(row["Gastos en insumos"].ToString()));
                ganVentas = new PdfPCell(new Phrase(row["Ganancias en ventas"].ToString()));
                canVendidos = new PdfPCell(new Phrase(row["Cantidad de vendidos"].ToString()));
                Semana = new PdfPCell(new Phrase(row["No. de semana"].ToString()));
                tabla.AddCell(ganancias);
                tabla.AddCell(gastosInsumos);
                tabla.AddCell(ganVentas);
                tabla.AddCell(canVendidos);
                tabla.AddCell(Semana);
            }
            documento.Add(tabla);
            #endregion
            System.Diagnostics.Process.Start(@"C:\Users\Leo J\Documents\Registros\Registros.pdf");
            documento.Close();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Close();
        }
        void Actualizar()
        {
            mt.Mostrar(dtgTotal);
        }
        private void FrmTotal_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Seguro que quieres iniciar una nueva semana?",
                "¡ATENCIÓN!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                ms.AgregarSemana();
                MessageBox.Show("La semana se ha actualizado a la semana "+dtgTotal.RowCount.ToString());
                Actualizar();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mb.BorrarTodo();
            Actualizar();
        }

        private void dtgTotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            total.NoSemana = int.Parse(dtgTotal.Rows[fila].Cells[5].Value.ToString());
            switch(columna)
            {
                case 6: {
                        mb.BorrarTotal(total);
                        Actualizar();
                    }break;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CrearPdf();
        }

        private void dtgTotal_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            columna = e.ColumnIndex;
            fila = e.RowIndex;
        }
    }
}
