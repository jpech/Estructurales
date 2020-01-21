using System;

namespace PatronProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ICocheService service = new CocheService();
            ICocheService proxy = new Proxy(service);
            Cliente cliente = new Cliente();
            cliente.ClientCode(proxy, "CodigoBueno");

            Console.ReadLine();
        }
    }
}
