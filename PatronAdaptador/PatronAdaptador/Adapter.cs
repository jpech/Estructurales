using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdaptador
{
    public class Adapter : ILector
    {
        private ILectorJson _adptee { get; set; }

        public Adapter(ILectorJson adptee)
        {
            _adptee = adptee;
        }

        public List<Ventas> ObtenerVentas()
        {
            List<Ventas> ventas = new List<Ventas>();
            var datos = _adptee.LeecArchivo();
            Ventas venta = JsonConvert.DeserializeObject<Ventas>(datos);
            ventas.Add(venta);
            return ventas;
        }
    }
}
