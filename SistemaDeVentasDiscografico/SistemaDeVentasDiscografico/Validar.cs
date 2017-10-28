using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeVentasDiscografico
{
    public class Validar
    {
        public static int TOINT(string num)
        {
            int numero = 0;
            int.TryParse(num, out numero);
            return numero;
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        
    }
}