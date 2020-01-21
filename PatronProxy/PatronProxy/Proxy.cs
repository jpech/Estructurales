using System;

namespace PatronProxy
{
    public class Proxy : ICocheService
    {
        private ICocheService _iService { get; set; }

        public Proxy(ICocheService iService)
        {
            _iService = iService;
        }

        public bool ChecarAcceso(string Codigo)
        {
            if (Codigo == "CodigoBueno")
                return true;
            else return false;
        }

        public void ArrancarCoche(string Codigo)
        {
            if (ChecarAcceso(Codigo))
            {
                Console.WriteLine($"Se encendió el motor.");
                _iService.ArrancarCoche(Codigo);
            }

            else
                Console.WriteLine("El código de la llave introducida es incorrecto.");
        }
    }
}
