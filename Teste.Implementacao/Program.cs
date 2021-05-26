using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Teste.Servicos;

namespace Teste.Implementacao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- {0} ", "Ancelmo Luiz"));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();

            Executar();

            stopwatch.Stop();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(string.Format("-- PROGRAMA FINALIZADO EM {0}ms", stopwatch.ElapsedMilliseconds));
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void Executar()
        {
            var linhas = File.ReadLines(@".\Arquivos\input.4.in");


            for (int i = 0; i < linhas.ToList().Count; i++)
            {
                bool numeroForaDoPadrao = true;
                var linha = linhas.ToList()[i];

                Console.WriteLine();
                Console.Write(string.Format("Teste #{0:00}: ", i + 1));
                Console.Write(string.Format("{0} ", linha));
                Console.Write(" >> ");


                string residencial = FormatarTelefoneResidencial.DeveFormatarNumeroResidencial(linha);
                if (!string.IsNullOrEmpty(residencial))
                {
                    Console.WriteLine(residencial);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string movel = FormatarTelefoneCelular.DeveFormatarNumeroCelular(linha);
                if (!string.IsNullOrEmpty(movel))
                {
                    Console.WriteLine(movel);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string SUP = FormatarSup.DeveFormatarSUP(linha);
                if (!string.IsNullOrEmpty(SUP))
                {
                    Console.WriteLine(SUP);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string telefoniaFixa = FormatarTelefoniaFixa.DeveFormatarTelefoniaFixa(linha);
                if (!string.IsNullOrEmpty(telefoniaFixa))
                {
                    Console.WriteLine(telefoniaFixa);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string telefoniaMovel = FormatarTelefoniaMovel.DeveFormatarTelefoniaMovel(linha);
                if (!string.IsNullOrEmpty(telefoniaMovel))
                {
                    Console.WriteLine(telefoniaMovel);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string tvPorAssinatura = FormatarTvPorAssinatura.DeveFormatarTvPorAssinatura(linha);
                if (!string.IsNullOrEmpty(tvPorAssinatura))
                {
                    Console.WriteLine(tvPorAssinatura);
                    numeroForaDoPadrao = false;
                    continue;
                }

                string numeroNaoGeografico = FormatarNumeroNaoGeografico.DeveFormatarNumeroNaoGeografico(linha);
                if (!string.IsNullOrEmpty(numeroNaoGeografico))
                {
                    Console.WriteLine(numeroNaoGeografico);
                    numeroForaDoPadrao = false;
                    continue;
                }

                if (numeroForaDoPadrao)
                {
                    Console.WriteLine("Número de telefone não identificado");
                    continue;
                }

                Console.WriteLine();
            }
        }
    }
}