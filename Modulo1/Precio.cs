using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    public class Precio
    {
        public int PrecioId { get; set; }
        public decimal PrecioActual { get; set; }
        public decimal Promocion { get; set; }
        public int CursoID { get; set; }
        
        //Es una Ancla
        //se crea una referencia para que sepa que es una foreign key y poder usarla a nivel de objeto
        public Curso Curso{ get; set; }
    }
}
