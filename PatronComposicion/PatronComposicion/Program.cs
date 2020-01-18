using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposicion
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente client = new Cliente();
            CompoundCalculador uax = new CompoundCalculador();

            CompoundCalculador ua = new CompoundCalculador();
            ICalculador cp = new UA(new ClavePresupuestal {NombreClave = "1", Enero = 1, Febrero = 2, Marzo = 3 });
            ICalculador cp2 = new UA(new ClavePresupuestal { NombreClave = "1.1", Enero = 4, Febrero = 5, Marzo = 6 });
            ICalculador cp3 = new UA(new ClavePresupuestal { NombreClave = "1.1.1", Enero = 7, Febrero = 8, Marzo = 9 });
            ua.Agregar(cp);
            ua.Agregar(cp2);
            ua.Agregar(cp3);

            CompoundCalculador ua2 = new CompoundCalculador();
            ICalculador ua2cp = new UA(new ClavePresupuestal { NombreClave = "2", Enero = 2, Febrero = 3, Marzo = 4 });
            ICalculador ua2cp2 = new UA(new ClavePresupuestal { NombreClave = "2.1", Enero = 5, Febrero = 6, Marzo = 7 });
            ICalculador ua2cp3 = new UA(new ClavePresupuestal { NombreClave = "2.1.1", Enero = 8, Febrero = 9, Marzo = 10 });
            ua2.Agregar(ua2cp);
            ua2.Agregar(ua2cp2);
            ua2.Agregar(ua2cp3);

            CompoundCalculador ua3 = new CompoundCalculador();
            ICalculador ua3cp = new UA(new ClavePresupuestal { NombreClave = "3", Enero = 3, Febrero = 4, Marzo = 5 });
            ICalculador ua3cp2 = new UA(new ClavePresupuestal { NombreClave = "3.1", Enero = 6, Febrero = 7, Marzo = 8 });
            ua3.Agregar(ua3cp);
            ua3.Agregar(ua3cp2);

            CompoundCalculador ua4 = new CompoundCalculador();
            ICalculador ua4cp = new UA(new ClavePresupuestal { NombreClave = "4", Enero = 4, Febrero = 5, Marzo = 6 });
            ua4.Agregar(ua4cp);

            uax.Agregar(ua);
            uax.Agregar(ua2);
            uax.Agregar(ua3);
            uax.Agregar(ua4);
            client.ClientCode(uax);

            Console.ReadLine();
        }
    }
}
