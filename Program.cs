using System;
using System.Collections.Generic;
using System.Linq;

namespace ActividadListasUniversidad
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MostrarSeparadorResultado("Simple");
            ListasEnlazadasSimples listasEnlazadasSimples = new ListasEnlazadasSimples();
            listasEnlazadasSimples.MostrarEjecucion();

            MostrarSeparadorResultado("Lista LIFO");
            ListaLIFO listaLIFO = new ListaLIFO();
            listaLIFO.MostrarEjecucion();

            MostrarSeparadorResultado("Lista FIFO");
            ListaFIFO listaFIFO = new ListaFIFO();
            listaFIFO.MostrarEjecucion();

            void MostrarSeparadorResultado(string tituloSeparador) {
                Console.WriteLine($"====================================");
                Console.WriteLine($"====================================");
                Console.WriteLine($"==========={tituloSeparador}=============");
                Console.WriteLine($"====================================");
                Console.WriteLine($"====================================");
            }
        }


    }
}
