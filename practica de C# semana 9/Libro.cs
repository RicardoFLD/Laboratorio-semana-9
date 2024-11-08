using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_de_C__semana_9
{
    public class Libro
    {
        public string Titulo { get; }
        public string Autor { get; }
        public int NumeroPaginas { get; set; }
        public decimal Precio { get; set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }

        public Libro(string titulo, string autor, int numeroPaginas, decimal precio)
        {
            Titulo = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Precio = precio;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Páginas: {NumeroPaginas}, Precio: {Precio:C}");
        }

        public void Descuento(decimal porcentaje)
        {
            Precio -= Precio * (porcentaje / 100);
        }

        public class LibroDigital : Libro
        {
            public double TamanioArchivo { get; set; }

            public LibroDigital(string titulo, string autor, int numeroPaginas, decimal precio, double tamanioArchivo)
                : base(titulo, autor, numeroPaginas, precio)
            {
                TamanioArchivo = tamanioArchivo;
            }
        }

        public override decimal CalcularPrecioConImpuesto()
        {
            return Precio * 1.13m;
        }

        public void MostrarDetallesIMP()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Páginas: {NumeroPaginas}, Precio sin impuesto: {Precio:C}");
            Console.WriteLine($"Precio con impuesto: {CalcularPrecioConImpuesto():C}");
        }
    }
}
