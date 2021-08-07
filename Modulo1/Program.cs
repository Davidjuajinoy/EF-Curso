using Microsoft.EntityFrameworkCore;
using System;

namespace Modulo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var db = new AppVentasCursosContext())
            //{
            //    var cursos = db.Curso.AsNoTracking();

            //    foreach (var curso in cursos)
            //    {
            //        Console.WriteLine(curso.Titulo);
            //    }

            //}

            // AsNoTracking sirve para que no almacene cache en memoria

            //using (var db = new AppVentasCursosContext())
            //{
            //    //incluyo los precios gracias a la prop PrecioPromocion que es de tipo Precio
            //    var cursos = db.Curso.Include(p => p.PrecioPromocion).AsNoTracking();

            //    foreach (var curso in cursos)
            //    {
            //        Console.WriteLine($"{curso.Titulo}: {curso.PrecioPromocion.PrecioActual}");
            //    }

            //}

            using (var db = new AppVentasCursosContext())
            {
                var cursos = db.Curso.Include(c => c.ComentariosLista).AsNoTracking();
                foreach (var curso in cursos)
                {
                    Console.WriteLine($"{curso.Titulo} tiene los comentarios: ");
                    foreach (var comentario in curso.ComentariosLista )
                    {
                        Console.WriteLine($"{comentario.ComentarioTexto}");
                    }
                }
            }

        }
    }
}
