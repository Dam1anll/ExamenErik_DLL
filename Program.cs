using ExamenErik_DLL.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenErik_DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            //Agregar a la lista

            for (int x = 0; x<5;x++) 
            {
                Console.WriteLine($"\nIngrese los datos de la Persona {x+1}: ");
                Console.WriteLine("Nombre: ");
                string nuevoNombre = Console.ReadLine();
                Console.WriteLine("Edad: ");
                int nuevaEdad = Convert.ToInt32(Console.ReadLine());
                Persona nuevaPersona = new Persona(nuevoNombre, nuevaEdad);
                lista.InsertarFinal(nuevaPersona);
            }

            //Buscar por Nombre

            /*lista.BuscarPersona();
            Console.WriteLine("Ingrese el nombre dela persona que quiera buscar");
            string nombreBuscar = Console.ReadLine();
            while()
            {
                if()
                {
                    Console.WriteLine($"La persona que busca se encuentra en la posicion: {}");
                }
                else
                {
                    Console.WriteLine("La persona que busca no se encuentra");
                }
            }*/

            //Mostrar lista 

            Console.WriteLine("\nLista de persona: ");
            lista.MostrarLista();

            Console.ReadKey();
        }
    }
}
