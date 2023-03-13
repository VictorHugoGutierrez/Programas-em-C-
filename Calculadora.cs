using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void soma(float a, float b)
        {
            float c;
            c = a + b;
            Console.WriteLine($"Os dois valores somados é: {c}");
        }

        static void sub(float a, float b)
        {
            float c;
            c = a - b;
            Console.WriteLine($"Os dois valores subtraidos é: {c}");
        }

        static void mult(float a, float b)
        {
            float c;
            c = a * b;
            Console.WriteLine($"Os dois valores multiplicados é: {c} ");
        }

        static void div(float a, float b)
        {
            float c;
            c = a / b;
            Console.WriteLine($"Os dois valores divididos é: {c}");
        }

        static void raiz(float a)
        {
            double c;

            c = Math.Sqrt(a);

            Console.WriteLine($"O resultado da Raiz quadrada é: {c}");
        }

        static void potencia(float a, float b)
        {
            double c;

            c = Math.Pow(a, b);
            Console.WriteLine($"O numero ao {b} eh: {c}");
        }

        static void Main(string[] args)
        {
            float x;


            do
            {
                Console.WriteLine("Menu de opções:\n");
                Console.WriteLine("(1) Somar dois números.");
                Console.WriteLine("(2) Subtrair dois números.");
                Console.WriteLine("(3) Multiplicar dois números.");
                Console.WriteLine("(4) Dividir dois números.");
                Console.WriteLine("(5) Raiz Quadrada de um número.");
                Console.WriteLine("(6) Potencia de um número.");
                Console.WriteLine("(0) Sair.\n");
                Console.WriteLine("Digite a opção desejada: ");
                x = float.Parse(Console.ReadLine());

                switch (x)
                {
                    case 1:
                        float a, b;
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite um valor: ");
                        b = float.Parse(Console.ReadLine());

                        soma(a, b);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite um valor: ");
                        b = float.Parse(Console.ReadLine());

                        sub(a, b);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite um valor: ");
                        b = float.Parse(Console.ReadLine());

                        mult(a, b);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite um valor: ");
                        b = float.Parse(Console.ReadLine());

                        div(a, b);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        raiz(a);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                       
                        Console.Clear();
                        Console.WriteLine("Digite um valor: ");
                        a = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite um valor para o expoente: ");
                        b = float.Parse(Console.ReadLine());

                        potencia(a, b);
                        Console.WriteLine("\nPrecisone Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case > 6:
                        Console.Clear();
                        Console.WriteLine("ERRO:");
                        Console.WriteLine("Digite um valor correspondente. \n");
                        Console.WriteLine("Pressione Enter pra continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (x != 0);
            Console.Clear();
        }
    }
}
