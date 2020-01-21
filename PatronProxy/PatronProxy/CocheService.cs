using System;

namespace PatronProxy
{
    public class CocheService : ICocheService
    {
        public void ArrancarCoche(string Codigo)
        {
            Console.WriteLine($"El coche con el código {Codigo} arrancó");
        }
    }
}