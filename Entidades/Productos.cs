using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos
    {
        public Productos(int id, string producto, double costo)
        {
            Id = id;
            Producto = producto;
            Costo = costo;
        }

        public int Id { get; set; }
        public string Producto { get; set; }
        public double Costo { get; set; }
    }
}
