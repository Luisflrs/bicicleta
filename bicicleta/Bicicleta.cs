using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicicleta
{
    class Bicicleta
    {
        public string marca { get; set; }
        public string  estilo { get; set; }
        public string color { get; set; }
        public string precio  { get; set; }

        public  Bicicleta(string _marca, string _estilo, string _color, string _precio)
        {
            marca = _marca;
            estilo = _estilo;
            color = _color;
            precio = _precio;
        
        }

        public string mostrarbike()
        {
            return "La marca de la bicileta adquirida es: " + marca + " estilo " + estilo + " entintada " + color + " por el precio de $" + precio; 
        }
    }
}
