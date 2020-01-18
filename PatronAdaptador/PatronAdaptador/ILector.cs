using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdaptador
{
    public interface ILector
    {
        List<Ventas> ObtenerVentas();
    }
}
