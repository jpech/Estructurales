using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaPorPagar cxp = new CuentaPorPagar { iIdCuentaPagar = 2154, cNaturaleza = "Naturaleza 1", dImporte = 527.00 };
            IServicio a = new Servicio();

            Console.WriteLine("Modificación 1");
            IServicio b = new DecoradorHistorial(a);
            b.GuardarCuentaPagar(cxp);
            Console.WriteLine("================");

            Console.WriteLine("Modificación 2");
            IServicio d = new DecoradorEmail(a);
            d.GuardarCuentaPagar(cxp);
            Console.WriteLine("================");

            Console.WriteLine("Modificación 3");
            IServicio e = new DecoradorHistorial(a);
            IServicio f = new DecoradorEmail(e);
            f.GuardarCuentaPagar(cxp);
            Console.WriteLine("================");

            Console.ReadLine();
        }
    }
}
