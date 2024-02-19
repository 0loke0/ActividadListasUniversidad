using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActividadListasUniversidad
{
    public class OperacionesConListas
    {
        public void ImprimirListaPorConsola(IEnumerable<int> lista)
        {
            foreach (var numero in lista)
            {
                Console.Write($"-{numero}");
            }
            Console.WriteLine("-");
        }

        public int ObtenerCantidadNumerosPares(IEnumerable<int> lista)
        {
            return lista.Where(w => (w % 2) == 0).Count();
        }

        public double ObtenerPromedio(IEnumerable<int> lista) {           
            return (double)lista.Sum() / (double)lista.Count();           
        }

        public int ObtenerUltimoDato(IEnumerable<int> lista)
        {
            return lista.LastOrDefault();
        }
        
        public void ImprimirListaPersonaPorConsola(IEnumerable<DTOPersona> personas)
        {
            foreach (var persona in personas)
            { Console.WriteLine($"======={persona.codigo}=======");
                Console.WriteLine($"Nombre: {persona.nombre}");
                Console.WriteLine($"Telefono: {persona.telefono}");
                Console.WriteLine($"Edad: {persona.edad}");
                Console.WriteLine("====================");
            }            
        }

        public int ObtenerConteoElementos(IEnumerable<DTOPersona> lista)
        {
            return lista.Count();
        }

    }
}
