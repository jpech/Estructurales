using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public class DHL : IEmpresa
    {
        public IMetodoEnvio _metodoEnvio { get; set; }

        public DHL(IMetodoEnvio metodoEnvio)
        {
            _metodoEnvio = metodoEnvio;
        }

        public void EntregarPedidos()
        {
            _metodoEnvio.DescargarPaquete();
            Console.WriteLine("La empresa DHL ha entregado el pedido");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("La empresa DHL ha enviado el pedido");
            _metodoEnvio.EnviarPaquete();
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("La empresa DHL ha recogido el pedido");
            _metodoEnvio.CargarPaquete();
        }
    }
}
