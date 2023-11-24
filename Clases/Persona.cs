using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenErik_DLL.Clases
{
    public class Persona
    {
        public string nombrePersona { get; set; }
        public int edadPersona { get; set; }

        public Persona(string _nombrePersona, int _edadPersona) 
        {
            nombrePersona = _nombrePersona;
            edadPersona = _edadPersona;
        }
    }
}
