using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActividadListasUniversidad
{
    public class ListasEnlazadasSimples
    {
        List<int> listaNumerosEnteros = new List<int>() { };
        List<DTOPersona> personas = new List<DTOPersona>() { };
        OperacionesConListas operacionesConListas = new OperacionesConListas();

        public ListasEnlazadasSimples() {
            AgregarNumeros();
            AgregarPersonas();
        }
        private void AgregarNumeros() {
            listaNumerosEnteros.Add(7);
            listaNumerosEnteros.Add(5);
            listaNumerosEnteros.Add(3);
            listaNumerosEnteros.Add(6);
            listaNumerosEnteros.Add(2);
            listaNumerosEnteros.Add(9);
        }
        private void AgregarPersonas() {
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
        }

        private void EliminarPrimerElemento() {
            personas.RemoveRange(0, 1);
        }

        public void MostrarEjecucion() {

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
