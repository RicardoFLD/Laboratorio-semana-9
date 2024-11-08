using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_de_C__semana_9
{
    internal class Ejercicio6
    {
        public class LibroEj6
        {
            private string titulo;
            private string autor;
            private int numeroPaginas;
            private decimal precio;

            public string Titulo
            {
                get { return titulo; }
            }

            public string Autor
            {
                get { return autor; }
            }

            public int NumeroPaginas
            {
                get { return numeroPaginas; }
                set
                {
                    if (value >= 0)
                        numeroPaginas = value;
                    else
                        Console.WriteLine("Número de páginas no puede ser negativo.");
                }
            }

            public decimal Precio
            {
                get { return precio; }
                set
                {
                    if (value >= 0)
                        precio = value;
                    else
                        Console.WriteLine("El precio no puede ser negativo.");
                }
            }

            public LibroEj6(string titulo, string autor, int numeroPaginas = 0, decimal precio = 0)
            {
                this.titulo = titulo;
                this.autor = autor;
                NumeroPaginas = numeroPaginas;
                Precio = precio;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Páginas: {NumeroPaginas}, Precio: {Precio:C}");
            }
        }
    }
}
