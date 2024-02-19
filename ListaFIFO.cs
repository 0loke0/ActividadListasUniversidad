using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadListasUniversidad
{
    public class ListaFIFO
    {
        Queue<int> listaNumerosEnteros = new Queue<int>() { };
        Queue<DTOPersona> personas = new Queue<DTOPersona>() { };
        OperacionesConListas operacionesConListas = new OperacionesConListas();
        public ListaFIFO() {
            AgregarNumeros();
            AgregarPersonas();
        }

        public void AgregarNumeros()
        {
            listaNumerosEnteros.Enqueue(7);
            listaNumerosEnteros.Enqueue(5);
            listaNumerosEnteros.Enqueue(3);
            listaNumerosEnteros.Enqueue(6);
            listaNumerosEnteros.Enqueue(2);
            listaNumerosEnteros.Enqueue(9);
        }

        private void AgregarPersonas()
        {
            personas.Enqueue(new DTOPersona
            {
                codigo = 1010,
                nombre = "Pedro",
                telefono = "123456",
                edad = 15
            });

            personas.Enqueue(new DTOPersona
            {
                codigo = 1011,
                nombre = "María",
                telefono = "654321",
                edad = 21
            });

            personas.Enqueue(new DTOPersona
            {
                codigo = 1012,
                nombre = "Daniela",
                telefono = "321654",
                edad = 25
            });

            personas.Enqueue(new DTOPersona
            {
                codigo = 1013,
                nombre = "Carlos",
                telefono = "45632",
                edad = 30
            });
        }

        private void EliminarPrimerElemento()
        {
            personas.Dequeue();
        }

        public void MostrarEjecucion()
        {

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

            //2.1 Mostar el ultimo dato de la lista
            Console.WriteLine("Mostrar la lista de los elementos (Personas)");
            operacionesConListas.ImprimirListaPersonaPorConsola(personas);

            //2.2 Elimina el primer elemento del la lista
            Console.WriteLine("Elimina el primer elemento del la lista");
            EliminarPrimerElemento();
            operacionesConListas.ImprimirListaPersonaPorConsola(personas);

            //2.3 Muestra la cantidad de elemento en la lista
            Console.WriteLine("Muestra la cantidad de elemento en la lista");
            operacionesConListas.ObtenerConteoElementos(personas);
        }

    }
}
