class conclusao1
{
    static void Main()
    {
        bool opcao = true;

        Console.WriteLine("Ola, irei realizar a soma de numeros que voce deseja ate voce desejar parar");

        Console.WriteLine("Digite o valor inicial: ");
        float.TryParse(Console.ReadLine(), out float inicial);

        while (opcao == true)
        {
            Console.WriteLine("Digite o numero que deseja somar ao numero inicial:");
            float.TryParse(Console.ReadLine(), out float n1);
            inicial = inicial + n1;
            Console.WriteLine("A soma é {0}", inicial);
            Console.WriteLine("Deseja sair do programa? \n (1) Sim \n (2) Não");
            int.TryParse(Console.ReadLine(), out int saida);
            switch (saida)
            {
                case 1:
                    Console.WriteLine("Saindo do Programa...");
                    opcao = false;
                    break;
                case 2:
                    Console.WriteLine("Continua a soma...");
                    break;
                default:
                    Console.WriteLine("Opção Inválida. Retornando para soma.");
                    break;
            }
        }
    }
}
