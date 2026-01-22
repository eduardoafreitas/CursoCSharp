using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto()
        {

        }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    internal class AtributosEstaticos
    {
        public static void Executar() 
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };

            Produto.Desconto = 0.5;

            Console.WriteLine("Preco com desconto prod1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto prod2: {0}", produto2.CalcularDesconto());

            Produto.Desconto = 0.02;

            Console.WriteLine("Preco com desconto prod1: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto prod2: {0}", produto2.CalcularDesconto());
        }
    }
}





