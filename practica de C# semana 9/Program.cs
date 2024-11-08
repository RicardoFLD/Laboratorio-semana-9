using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practica_de_C__semana_9.Libro;

namespace practica_de_C__semana_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("El Principito", "Antoine de Saint-Exupéry") { NumeroPaginas = 96, Precio = 8500 };
            Libro libro2 = new Libro("1984", "George Orwell") { NumeroPaginas = 328, Precio = 7500 };
            Libro libro3 = new Libro("Cien Años de Soledad", "Gabriel García Márquez") { NumeroPaginas = 417, Precio = 6700 };

            Libro libro4 = new Libro("El Principito", "Antoine de Saint-Exupéry");
            Libro libro5 = new Libro("Cien Años de Soledad", "Gabriel García Márquez", 417, 8900);
            LibroDigital libroDigital1 = new LibroDigital("1984", "George Orwell", 328, 18.99m, 7500);

            libro1.Descuento(10);
            libro2.Descuento(10);
            libro3.Descuento(10);

            libro1.MostrarDetalles();
            libro2.MostrarDetalles();
            libro3.MostrarDetalles();
            libro4.MostrarDetalles();
            libro5.MostrarDetalles();

            Libro libro7 = new Libro("El Principito", "Antoine de Saint-Exupéry", 96, 9500);

            Libro libro8 = new Libro("La historia del loco", "Jhon katzenbach", 04, 7800);

            libro7.NumeroPaginas = -50; 
            libro7.Precio = -10.99m;    

            libro7.MostrarDetalles();

            libro1.MostrarDetalles();
            Console.WriteLine();
            libroDigital1.MostrarDetalles();

            libro1.MostrarDetallesIMP();
        }

    }
}
