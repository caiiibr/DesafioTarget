using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Usando dados ficticios pois não domino o uson de arquivos JSON
                decimal[] faturamentoMensal = {
            1000, 1500, 2000, 800, 1200, 0, 1800, 1600, 1400, 1700, 1900, 1100, 1300,
            1000, 1500, 1800, 1200, 1400, 1600, 0, 1900, 2000, 1700, 1300, 1100, 800,
            1400, 1600, 1500, 1900, 1700
        };

                decimal menorFaturamento = EncontrarMenorFaturamento(faturamentoMensal);
                decimal maiorFaturamento = EncontrarMaiorFaturamento(faturamentoMensal);

               
                decimal mediaMensal = CalcularMediaMensal(faturamentoMensal);

                int diasAcimaMedia = ContarDiasAcimaMedia(faturamentoMensal, mediaMensal);

                Console.WriteLine($"Menor valor de faturamento: {menorFaturamento}");
                Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento}");
                Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaMedia}");
                Console.ReadLine();
            }

            static decimal EncontrarMenorFaturamento(decimal[] faturamento)
            {
                decimal menor = decimal.MaxValue;
                foreach (decimal valor in faturamento)
                {
                    if (valor < menor)
                        menor = valor;
                }
                return menor;
            }

            static decimal EncontrarMaiorFaturamento(decimal[] faturamento)
            {
                decimal maior = decimal.MinValue;
                foreach (decimal valor in faturamento)
                {
                    if (valor > maior)
                        maior = valor;
                }
                return maior;
            }

            static decimal CalcularMediaMensal(decimal[] faturamento)
            {
                decimal soma = 0;
                int diasUteis = 0;
                foreach (decimal valor in faturamento)
                {
                    if (valor > 0) // Considerar apenas dias úteis (com faturamento maior que zero)
                    {
                        soma += valor;
                        diasUteis++;
                    }
                }
                return diasUteis == 0 ? 0 : soma / diasUteis;
            }

            static int ContarDiasAcimaMedia(decimal[] faturamento, decimal media)
            {
                int contador = 0;
                foreach (decimal valor in faturamento)
                {
                    if (valor > media)
                        contador++;
                }
                return contador;
            }
        }

    }