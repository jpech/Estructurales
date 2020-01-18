using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public class DecoradorEmail : IServicio
    {
        public IServicio _service { get; set; }

        public DecoradorEmail(IServicio service)
        {
            _service = service;
        }

        public void GuardarCuentaPagar(CuentaPorPagar cp)
        {
            _service.GuardarCuentaPagar(cp);
            Console.WriteLine("Correo de notifación enviada.");
        }
    }
}
