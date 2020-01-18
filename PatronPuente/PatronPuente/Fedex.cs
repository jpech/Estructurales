using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public class Fedex : IEmpresa
    {
        public IMetodoEnvio _metodoEnvio { get; set; }

        public Fedex(IMetodoEnvio metodoEnvio)
        {
            _metodoEnvio = metodoEnvio;
        }

        public void EntregarPedidos()
        {
            _metodoEnvio.DescargarPaquete();
            Console.WriteLine("La empresa Fedex ha entregado el pedido");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("La empresa Fedex ha enviado el pedido");
            _metodoEnvio.EnviarPaquete();
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("La empresa Fedex ha recogido el pedido");
            _metodoEnvio.CargarPaquete();
        }
    }
}
