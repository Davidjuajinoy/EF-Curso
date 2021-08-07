using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo1
{
    public class Comentario
    {
        public int ComentarioId { get; set; }
        public string Alumno  { get; set; }
        public int Puntaje { get; set; }
        public string ComentarioTexto { get; set; }
        public int CursoId { get; set; }

        //el ancla , foreing key a nivel de objeto
        public Curso Curso { get; set; }

    }
}
