using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    /// <summary>
    /// Conexion DB
    /// </summary>
    public class Curso
    {
        public int CursoId { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public string FotoPortada { get; set; }

        //importante
        //para que curso pueda instanciar y consumir datos de precio , esta no es la foreingkey 
        /*Relacion uno a uno (un curso tiene un unico precio)*/
        public Precio PrecioPromocion{ get; set; }


        /*Relacion uno  a muchos (un curso tiene muchos comentarios )
         */
        public ICollection<Comentario> ComentariosLista { get; set; }
    }
}
