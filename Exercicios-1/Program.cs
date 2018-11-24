using System;

namespace Exercicios_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
           Escreva um programa que armazena o valor 999 na variável A e o valor 555 na variável B.
           A seguir troque os seus conteúdos fazendo com que o valor que está em A passe para B e 
           vise-versa utilizando a variável C para realizar a troca.
           */

           int A = 999;
           int B = 555;
           int C = 0;

           Console.WriteLine("A ==> " + A);
           Console.WriteLine("B ==> " + B);
           Console.WriteLine("C ==> " + C);
           Console.WriteLine("== TROCA ==");
           C = A;
           A = B;
           B = C;
           Console.WriteLine("A ==> " + A);
           Console.WriteLine("B ==> " + B);
           Console.WriteLine("C ==> " + C);
        }
    }
}
