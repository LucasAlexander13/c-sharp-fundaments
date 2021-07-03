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
                Console.WriteLine('0 argumentos')
            }
            else if (args.Length == 1)
            {
                Console.WriteLine('1 argumento')
            }
            else
            {
                Console.WriteLine($'{args.Length} argumentos')
            }
        }

        static void InstrucaoSwitch(string[] args)
    }
}
