using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ventas
    {
        public Ventas(int id, int idproducto, int cantidadVendido)
        {
            Id = id;
            _Idproducto = idproducto;
            CantidadVendido = cantidadVendido;
        }

        public int Id { get; set; }
        public int _Idproducto { get; set; }
        public int CantidadVendido { get; set; }
    }
}
