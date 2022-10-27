using System;

namespace TipoByteInt
{
    class Program
    {
        static void Main(string[] args)

        {
            byte v1 = 10;
            Console.WriteLine("o valor de v1 é: {0}", v1);
            Console.WriteLine("o tipo é: {0}", v1.GetType());



            Console.WriteLine("digite um valor na faixa de 0 a 255");

            try
            {
                byte vdigitado = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("O valor digitado é byte");
            }
            catch (OverflowException) {
                Console.WriteLine("o valor digitado não é byte");
                var vdigitado = Convert.ToByte(Console.ReadLine());
                if (vdigitado <= 255)
                {
                    Console.WriteLine("o valor digitado é byte");
                }
                else
                {
                    Console.WriteLine("o valor digitado não é byte");

                }

            }
 {
 