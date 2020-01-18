using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public class Servicio : IServicio
    {
        public void GuardarCuentaPagar(CuentaPorPagar cp)
        {
            Console.WriteLine($"Se ha guardado la CXP con el identificador {cp.iIdCuentaPagar}" );
        }
    }
}
