using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposicion
{
    public class CompoundCalculador : ICalculador
    {
        public List<ICalculador> Hijos { get; set; }

        public CompoundCalculador()
        {
            Hijos = new List<ICalculador>();
        }

        public void Agregar(ICalculador hijo)
        {
            Hijos.Add(hijo);
        }

        public void Eliminar(ICalculador hijo)
        {
            Hijos.Remove(hijo);
        }

        public double ImprimirSaldo()
        {
            double saldo = 0;
            foreach (var item in Hijos)
            {
                saldo += item.ImprimirSaldo();
            }
            Console.WriteLine("La suma total es: " + saldo + "\n");
            Console.WriteLine("=============================================");
            return saldo;
        }
    }
}
