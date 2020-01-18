using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdaptador
{
    public class LectorJson : ILectorJson
    {
        public string LeecArchivo()
        {
            string json = @"{
                  'iIdSucursal': '1',
                      'cNombreSucursal': 'Periferico',
                      'dTotalVentas': '524.20'
              }";

            return json;
        }
    }
}
