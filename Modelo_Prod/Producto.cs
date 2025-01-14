using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  WindowsFormsProductos.Modelo_Prod
{
    public class Producto
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string categoria { get; set; }
        public double precio { get; set; }
        public int stock { get; set; }
        public string proveedor { get; set; }
    }
}
