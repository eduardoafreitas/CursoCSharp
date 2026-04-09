using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // arredondando com formatação de 1 casa decimal
            Console.WriteLine(valor.ToString("C")); // currency
            Console.WriteLine(valor.ToString("P")); // percentual
            Console.WriteLine(valor.ToString("#.##")); // como se fosse "F2"

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}