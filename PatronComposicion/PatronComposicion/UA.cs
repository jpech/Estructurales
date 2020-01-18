using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposicion
{
    public class UA : ICalculador
    {
        public ClavePresupuestal _CP { get; set; }

        public UA(ClavePresupuestal CP)
        {
            _CP = CP;
        }

        public double ImprimirSaldo()
        {
            double total = 0;
            total = _CP.Enero + _CP.Febrero + _CP.Marzo;
            Console.WriteLine($"CP: { _CP.NombreClave } : ${ total} \n");
            return total;
        }
    }
}
