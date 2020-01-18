using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    public class Estafeta : IEmpresa
    {
        public IMetodoEnvio _metodoEnvio { get; set; }

        public Estafeta(IMetodoEnvio metodoEnvio)
        {
            _metodoEnvio = metodoEnvio;
        }

        public void EntregarPedidos()
        {
            Console.WriteLine("La empresa Estafeta ha cargado el pedido");
        }

        public void EnviarPedidos()
        {
            Console.WriteLine("La empresa Estafeta ha enviado el pedido");
        }

        public void RecogerPedidos()
        {
            Console.WriteLine("La empresa Estafeta ha recogido el pedido");
        }
    }
}
