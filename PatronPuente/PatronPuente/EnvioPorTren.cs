using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public class EnvioPorTren : IMetodoEnvio
    {
        public void CargarPaquete()
        {
            Console.WriteLine("Se ha cargado el paquete en el tren");
        }

        public void DescargarPaquete()
        {
            Console.WriteLine("Se ha descargado el paquete del tren");
        }

        public void EnviarPaquete()
        {
            Console.WriteLine("Se ha enviado el paquete por tren");
        }
    }
}
