using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposicion
{
    public class Cliente
    {
        public void ClientCode(ICalculador leaf)
        {
            leaf.ImprimirSaldo();
        }
    }
}
