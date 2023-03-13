using System.Linq.Expressions;
using System.Xml.Serialization;

namespace IMC
{ 
    class Program
    {
        public static float calcula(float massa, float altura)
        {
            return massa / (altura * altura);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a sua massa: ");
            float m = float.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a sua altura: ");
            float a = float.Parse(Console.ReadLine());

            float imc = calcula(m, a);

            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC eh: {0:N1}", imc);
                Console.WriteLine("Seu indice eh Abaixo do Peso ");
            }
            else if ((imc >= 18.5) && (imc <= 24.9))
            {
                Console.WriteLine("Seu IMC eh: {0:N1}", imc);
                Console.WriteLine("Seu indice eh Peso Normal");
            }
            else if ((imc >= 25) && (imc <= 29.9))
            {
                Console.WriteLine("Seu IMC eh:{0:N1}", imc);
                Console.WriteLine("Seu indice eh Execesso de Peso");
            }
            else if ((imc >= 30) && (imc <= 34.9))
            {
                Console.WriteLine("Seu IMC eh: {0:N1}", imc);
                Console.WriteLine("Seu indice eh Obesidade");
            }
            else
            {
                Console.WriteLine("Seu IMC eh: {0:N1}", imc);
                Console.WriteLine("Seu indice eh Obesidade Extrema");
            }
        }
    }
}
