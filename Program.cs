﻿using System;

namespace TIPOS_DE_VARÍAVEIS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = num1;
            int resultado = num1 + num2;
            num1 = 6;

            Console.WriteLine("valor do num1 é: {0} e está na stack", num1.ToString());
            Console.WriteLine("valor do num2 é: {0} e está na stack", num2.ToString());
            Console.ReadKey();
            Console.WriteLine("Calculadora");
            Calculadora minhacalculadora = new Calculadora();
            minhacalculadora.somar();

            Console.WriteLine("Variaveis nullo,");
            int? altura = null;

            if (altura.HasValue)
            {
                Console.WriteLine("o valor é: {0}: ", altura);
            }
            else
            {
                Console.WriteLine("altura está nullo");
            }   




            Console.WriteLine(altura.ToString());

            Console.ReadKey();
             }
           
    }
}
