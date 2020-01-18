using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdaptador
{
    public class Servicio : ILector
    {
        public List<Ventas> ObtenerVentas()
        {
            List<Ventas> ventas = new List<Ventas>();

            for (int i = 1; i < 6; i++)
            {
                Ventas venta = new Ventas();
                venta.iIdSucursal = i;
                venta.cNombreSucursal = $"Sucursal {i}";
                venta.dTotalVentas = i * 3;
                ventas.Add(venta);
            }

            return ventas;
        }
    }
}
