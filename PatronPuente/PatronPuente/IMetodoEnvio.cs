using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public interface IMetodoEnvio
    {
        void CargarPaquete();
        void EnviarPaquete();
        void DescargarPaquete();
    }
}
