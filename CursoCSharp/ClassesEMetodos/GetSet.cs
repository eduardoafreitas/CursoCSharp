using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class GetSet
    {
        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;

            public Moto(string marca, string modelo, int cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }

            public Moto()
            {

            }

            public string GetMarca()
            {
                return Marca;
            }

            public void SetMarca(string marca)
            {
                Marca = marca;
            }

            public string GetModelo()
            {
                return Modelo;
            }

            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }

            public int GetCilindrada()
            {
                return Cilindrada;
            }

            public void SetCilindrada(int cilindrada)
            {
                //if (cilindrada < 0)
                //{
                //    Cilindrada = cilindrada;
                //}

                Cilindrada = Math.Abs(cilindrada);
             }
        }

        public static void Executar()
        {
            var moto1 = new Moto("Kawazaki", "Ninja ZX-6R", 900);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("XRE");
            moto2.SetCilindrada(-300);
            Console.WriteLine($"{moto2.GetMarca()} {moto2.GetModelo()} {moto2.GetCilindrada()}");
        }
    }
}
