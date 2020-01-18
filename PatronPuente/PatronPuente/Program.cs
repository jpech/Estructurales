using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronPuente
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente client = new Cliente();

            IMetodoEnvio porMar = new EnvioPorBarco();
            IEmpresa fedex = new Fedex(porMar);
            client.ClientCode(fedex);
            Console.WriteLine("===============");

            IMetodoEnvio aire = new EnvioPorAvion();
            IEmpresa dhl = new DHL(aire);
            client.ClientCode(dhl);
            Console.WriteLine("===============");

            Console.ReadLine();
        }
    }
}
