using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Modelo.Nodo
{
    public class NodoString : Nodo<string, NodoString>
    {
        public override string Valor { get; set; }
        public override NodoString Siguiente { get ; set; }
    }
}
