using System;

namespace Fundamentos.Exemplos
{
    class Estruturas
    {
        static void Declaracoes()
        {
            int numA;
            int numB = 2, numC = 3;
            const int numD = 4;
            numA = 1;

            Console.WriteLine(numA + numB + numC + numD);
        }

        static void InstrucaoIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento")
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("1 argumento")
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos")
            }
        }

        static void InstrucaoSwitch(string[] args)
        {
            int numArgs = args.Length;
            switch(numArgs)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("1 argumento");
                    break;
                default:
                    Console.WriteLine($"{numArgs} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }
    }
}
