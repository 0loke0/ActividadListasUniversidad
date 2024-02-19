using System;
using System.Collections.Generic;
using System.Text;

namespace ActividadListasUniversidad
{
    public class ListaLIFO
    {
        Stack<int> listaNumerosEnteros = new Stack<int>(){ };
        Stack<DTOPersona> personas = new Stack<DTOPersona>(){ };
        OperacionesConListas operacionesConListas = new OperacionesConListas();
        public ListaLIFO() {
            AgregarNumeros();
            AgregarPersonas();
        }

        public void AgregarNumeros() {
            listaNumerosEnteros.Push(7);
            listaNumerosEnteros.Push(5);
            listaNumerosEnteros.Push(3);
            listaNumerosEnteros.Push(6);
            listaNumerosEnteros.Push(2);
            listaNumerosEnteros.Push(9);            
        }

        private void AgregarPersonas()
        {
            personas.Push(new DTOPersona
            {
                codigo = 1010,
                nombre = "Pedro",
                telefono = "123456",
                edad = 15
            });

            personas.Push(new DTOPersona
            {
                codigo = 1011,
                nombre = "María",
                telefono = "654321",
                edad = 21
            });

            personas.Push(new DTOPersona
            {
                codigo = 1012,
                nombre = "Daniela",
                telefono = "321654",
                edad = 25
            });

            personas.Push(new DTOPersona
            {
                codigo = 1013,
                nombre = "Carlos",
                telefono = "45632",
                edad = 30
            });
        }
        private void EliminarPrimerElemento()
        {
            personas.Pop();
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
