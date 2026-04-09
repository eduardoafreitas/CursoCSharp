using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            //PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A área é: " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("A idade é: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("O saldo de gols mínimo é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário é " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor int é " + menorValorInt); // Mais usado dos inteiros

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População brasileira é " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long é " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial é " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é " + precoComputador);

            double valorMercadoDaApple = 1_000_000_000_000.00; // Mais usado dos reais!
            Console.WriteLine("Valor Apple é " + valorMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas é " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Inserindo um texto aqui! Z";
            Console.WriteLine(texto);
        }
    }
}
