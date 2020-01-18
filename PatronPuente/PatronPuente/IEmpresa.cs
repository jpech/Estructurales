using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public interface IEmpresa
    {
        void RecogerPedidos();

        void EnviarPedidos();

        void EntregarPedidos();
    }
}
