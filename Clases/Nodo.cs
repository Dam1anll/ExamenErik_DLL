using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenErik_DLL.Clases;

namespace ExamenErik_DLL.Clases
{
    public class Nodo
    {
        public Persona datos { get; set; }
        public Nodo siguiente { get; set; }

        public Nodo(Persona persona) 
        {
            datos = persona;
            siguiente = null;
        }
        
    }
}
