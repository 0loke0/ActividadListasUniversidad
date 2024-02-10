using System;
using System.Collections.Generic;
using System.Linq;

namespace ActividadListasUniversidad
{
    class Program
    {
        public class DTOPersona {
            public int codigo { get; set; }
            public string nombre { get; set; }
            public string telefono { get; set; }
            public int edad { get; set; }


        }
        static void Main(string[] args)
        {
            List<int> listaNumerosEnteros = new List<int>() {7,5,3,6,2,9};
            List<DTOPersona> personas = new List<DTOPersona>(){ };
            personas.Add(new DTOPersona
            {
                codigo = 1010,
                nombre = "Pedro",
                telefono = "123456",
                edad = 15
            });

            personas.Add(new DTOPersona
            {
                codigo = 1011,
                nombre = "María",
                telefono = "654321",
                edad = 21
            });

            personas.Add(new DTOPersona
            {
                codigo = 1012,
                nombre = "Daniela",
                telefono = "321654",
                edad = 25
            });

            personas.Add(new DTOPersona
            {
                codigo = 1013,
                nombre = "Carlos",
                telefono = "45632",
                edad = 30
            });

            OperacionesConListas operacionesConListas = new OperacionesConListas();

            //1.1 Mostrar los datos de la lista
            Console.WriteLine("Mostrar los datos de la lista");
            operacionesConListas.ImprimirListaPorConsola(listaNumerosEnteros);

            //1.2 Mostar la cantidad de números pares que hay en la lista 
            Console.WriteLine("Mostar la cantidad de números pares que hay en la lista ");
            Console.WriteLine(operacionesConListas.ObtenerCantidadNumerosPares(listaNumerosEnteros));

            //1.3 Mostar el promedio de la lista.
            Console.WriteLine("Mostar el promedio de la lista");
            Console.WriteLine(operacionesConListas.ObtenerPromedio(listaNumerosEnteros));

            //1.4 Mostar el ultimo dato de la lista
            Console.WriteLine("Mostar el ultimo dato de la lista");
            Console.WriteLine(operacionesConListas.ObtenerUltimoDato(listaNumerosEnteros));


        }


    }
}
