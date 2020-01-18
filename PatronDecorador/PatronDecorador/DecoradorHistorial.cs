using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public class DecoradorHistorial : IServicio
    {
        public IServicio _service { get; set; }

        public DecoradorHistorial(IServicio service)
        {
            _service = service;
        }

        public void GuardarCuentaPagar(CuentaPorPagar cp)
        {
            _service.GuardarCuentaPagar(cp);
            Console.WriteLine($"Se ha guardado el historial de la CXP con identificador {cp.iIdCuentaPagar}");
        }
    }
}
