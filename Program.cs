using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Digite quantos segundos deseja contar: ");

            Cronometro();

        }

        static void Cronometro()
        {
            int segundos = int.Parse(Console.ReadLine());
            Preparacao();
            int tempo = 0;
            segundos = segundos + 1;
            while (segundos > tempo)
            {

                segundos--;
                Console.WriteLine(segundos);
                Thread.Sleep(1000);

            }

        }


        static void Preparacao()
        {
            Console.WriteLine("Começando a contagem.");
            Thread.Sleep(900);
            Console.Clear();
            Console.WriteLine(".");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("..");
            Thread.Sleep(400);
            Console.Clear();
            Console.WriteLine("...");
            Thread.Sleep(360);
            Console.Clear();
            Console.WriteLine("Agora.");
            Console.Clear();
        }

    }
}
