using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorador
{
    public interface IServicio
    {
        void GuardarCuentaPagar(CuentaPorPagar cp);
    }
}
