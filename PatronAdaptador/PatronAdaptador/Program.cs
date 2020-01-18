using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdaptador
{
    class Program
    {
        static void Main(string[] args)
        {
            ILector srv = new Servicio();
            foreach (var item in srv.ObtenerVentas())
            {
                Console.WriteLine("Identificador de la sucursal: " + item.iIdSucursal);
                Console.WriteLine(item.cNombreSucursal);
                Console.WriteLine("Total de ventas: " + item.dTotalVentas);
                Console.WriteLine("//////////////////////");
            }

            ILectorJson json = new LectorJson();
            ILector adapter = new Adapter(json);

            Console.WriteLine("Con JSON");
            foreach (var item in adapter.ObtenerVentas())
            {
                Console.WriteLine("Identificador de la sucursal: " + item.iIdSucursal);
                Console.WriteLine(item.cNombreSucursal);
                Console.WriteLine("Total de ventas: " + item.dTotalVentas);
                Console.WriteLine("//////////////////////");
            }
            Console.ReadLine();
        }
    }
}
