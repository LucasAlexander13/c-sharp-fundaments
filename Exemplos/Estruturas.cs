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

        static void InstrucaoDoWhile(string[] args)
        {
            string texto;
            do
            {
                texto = Console.ReadLine();
                Console.WriteLine(texto);
            } while (!string.IsNullOrEmpty(texto));
        }

        static void InstrucaoFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(string[] args)
        {
            foreach (string str in args)
            {
                Console.WriteLine(str);
            }
        }

        static void InstrucaoBreak(string[] args)
        {
            while (true)
            {
                string str = Console.ReadLine();

                if (string.IsNullOrEmpty(str))
                {
                    break;
                }

                Console.WriteLine(str);
            }
        }

        static void InstrucaoContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                {
                    continue;
                }
                
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(string[] args)
        {
            int Somar(int numA, int numB)
            {
                return numA + numB;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
            Console.WriteLine(Somar(5, 6));
            return;
        }

        static void InstrucoesTryCatchFinallyThrow(string[] args)
        {
            double Dividir(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 n??meros.");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro gen??rico: {e.Message}");
            }
            finally
            {
                Console.WriteLine("At?? breve!");
            }
        }

        static void InstrucaoUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }

    }
}
