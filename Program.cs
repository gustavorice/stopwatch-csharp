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
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string dados = Console.ReadLine().ToLower();

            char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
            int time = int.Parse(dados.Substring(0, dados.Length - 1));
            int multiplicador = 1;

            if (tipo == 'm')
            {
                multiplicador = 60;
            }

            int numeroFinal = time * multiplicador;

            Start(numeroFinal);


        }

        static void Start(int temporizador)
        {
            int usertime = 0;
            while (usertime != temporizador)
            {
                usertime++;
                Console.WriteLine(usertime);
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
        }


    }
}
