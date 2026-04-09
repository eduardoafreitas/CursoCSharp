using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        
        public static void Executar() 
        {
            // acessar a variavel 'a' dentro do metodo Executar
            //Console.WriteLine(a); 

            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
