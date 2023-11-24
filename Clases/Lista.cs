using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenErik_DLL.Clases;

namespace ExamenErik_DLL.Clases
{
    public class Lista
    {
        public Nodo inicio { get; set; }
        public Lista() 
        {
            inicio = null;
        }

        public bool ListaVacia() 
        {
            return inicio == null;
        }

        public void InsertarFinal(Persona persona) 
        {
            Nodo nodo = new Nodo(persona);

            if(inicio == null) 
            {
                inicio = nodo;
                return;
            }

            Nodo actual = inicio;

            while(actual.siguiente != null) 
            {
                actual = actual.siguiente;
            }

            actual.siguiente = nodo;
        }

        /*
        public void BuscarPersona() 
        {
            Console.WriteLine("Ingrese el nombre dela persona que quiera buscar");
            string nombreBuscar = Console.ReadLine();

            for (int y = 0; y < 5; y++) 
            {
                if(nombreBuscar == ) 
                {
                    Console.WriteLine($"La persona que busca se encuentra en la posicion:");
                }
                else 
                {
                    Console.WriteLine("La persona que busca no se encuentra");
                }
            }
        }
        */

        public void MostrarLista() 
        {
            Nodo nodoActual = inicio;

            while(nodoActual != null) 
            {
                Console.WriteLine($"Nombre: {nodoActual.datos.nombrePersona}, Edad: {nodoActual.datos.edadPersona}");
                nodoActual = nodoActual.siguiente;
            }
        }
    }
}
