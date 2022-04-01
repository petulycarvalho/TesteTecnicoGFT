using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = 0;

            Console.WriteLine("Insira o tamanho do vetor:");
            tamanhoVetor = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($"Preencha a posicao {i} do vetor");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            int quantidadePares = 0;
            int quantidadeImpares = 0;
            int quantidadeNumerosRepetidos = 0;
            List<int> numerosNaoRepetidos = new List<int>();
            List<int> numerosRepetidos = new List<int>();

            List<int> numeros = vetor.ToList();

            foreach (int num in numeros)
            {
                if (num % 2 == 0) quantidadePares++;
                else quantidadeImpares++;

                if (!numerosNaoRepetidos.Contains(num)) numerosNaoRepetidos.Add(num);
                else
                {
                    if (!numerosRepetidos.Contains(num))
                    {
                        quantidadeNumerosRepetidos++;
                        numerosRepetidos.Add(num);
            }
                }
            }

            Console.WriteLine($"Quantidade numeros pares = {quantidadePares}");
            Console.WriteLine($"Quantidade numeros impares = {quantidadeImpares}");
            Console.WriteLine($"Quantidade numeros repetidos = {quantidadeNumerosRepetidos}");

            Console.WriteLine("Numeros repetidos");
            foreach (int num in numerosRepetidos)
            {
                Console.WriteLine(num);

            }
        }
    }
}
