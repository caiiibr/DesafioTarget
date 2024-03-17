using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Digite um número:");
                int numeroProcurado = int.Parse(Console.ReadLine());    
                int primeiro = 0;
                int segundo = 1;

                while (primeiro <= numeroProcurado)
                {
                    if (primeiro == numeroProcurado)
                    {
                        Console.WriteLine($"O número {numeroProcurado} pertence à sequência de Fibonacci.");
                        Console.WriteLine("Pressione qualquer tecla para sair...");
                        Console.ReadLine();
                    return;
                       
                }

                    int proximo = primeiro + segundo;
                    primeiro = segundo;
                    segundo = proximo;
                }

                Console.WriteLine($"O número {numeroProcurado} NÃO pertence à sequência de Fibonacci.");
                
                Console.WriteLine("Pressione qualquer tecla para sair...");
                Console.ReadLine();
        }
        
        }

    }
