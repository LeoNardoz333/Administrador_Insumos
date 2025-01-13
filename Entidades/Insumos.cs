using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Insumos
    {
        public Insumos(int id, string nombre, double precioUnitario, int cantidad, int noSemana)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
            NoSemana = noSemana;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public int NoSemana { get; set; }
    }
}
