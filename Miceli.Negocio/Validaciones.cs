using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Miceli.Negocio
{
    public class Validaciones
    {
        public static bool EsMailValido(string mail)
        {
            string regExp = "^(([^<>()\\[\\]\\.,;:\\s@”]+(\\.[^<>()\\[\\]\\.,;:\\s@”]+)*)|(“.+”))@((\\[[0–9]{1,3}\\.[0–9]{1,3}\\.[0–9]{1,3}\\.[0–9]{1,3}])|(([a-zA-Z\\-0–9]+\\.)+[a-zA-Z]{2,}))$";
            return Regex.IsMatch(mail, regExp);
        }

        public static bool EsTextBoxValido(string input)
        {
            if(String.IsNullOrEmpty(input))
            {
                return false;
            }

            return true;
        }

        public static bool EsNotaValida(decimal nota)
        {
            if (nota < 0 && nota > 10)
            {
                return false;
            }

            return true;
        }

        public static bool EsFechaValida(DateTime fecha) 
        {
            return true;
        }

        public void ValidarInputs()
        {

        }
    }
}
