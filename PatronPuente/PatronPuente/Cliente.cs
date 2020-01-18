using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public class Cliente
    {
        public void ClientCode(IEmpresa empresa)
        {
            empresa.RecogerPedidos();
            empresa.EnviarPedidos();
            empresa.EntregarPedidos();
        }
    }
}
