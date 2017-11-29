using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaDeVentasDiscografico
{
    public class util
    {
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        public static int TOINT(string nombre)
        {
            int numero;
            int.TryParse(nombre, out numero);
            return numero;
        }
        internal static int ToInt()
        {
            try
            {
                Utilidades.ToInt();
                return ToInt();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}