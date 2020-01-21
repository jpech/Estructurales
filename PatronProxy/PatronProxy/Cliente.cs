using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronProxy
{
    public class Cliente
    {
        public void ClientCode(ICocheService service, string codigo)
        {
            service.ArrancarCoche(codigo);
        }
    }
}
