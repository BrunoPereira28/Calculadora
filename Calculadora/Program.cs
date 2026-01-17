namespace calculadora;

public class Program
{
    static void Main()
    {
        calculadora();
    }
    /*
        Chama a função da caculadora e mostra as opções disponíveis para o usuário. Após o usuário digitar a opção, ela será armazenada na variável "escolha".
     */
    static void calculadora()
    {
        Console.WriteLine("Calculadora");
        Console.WriteLine("Digite uma das opções abaixo:");
        Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Porcentagem\n6 - Potência");

        int escolha = int.Parse(Console.ReadLine()!);

        /*
          Usa o comando switch/case para chamar cada função de operações matemáticas com base no número que o usuário digitar.
        */
        switch (escolha)
        {
            case 1:
                adicao();
                break;
            case 2:
                subtracao();
                break;
            case 3:
                multiplicacao();
                break;
            case 4:
                divisao();
                break;
            case 5:
                porcentagem();
                break;
            case 6:
                potencia();
                break;
            default:
                erro();
                break;
        }

        /*
            Função para que caso o usuário digite um número inválido, irá aparecer limpar o terminal, aparecer mensagem abaixo, limpar novamente o terminal e voltar para as opções da calculadora.
        */
        static void erro()
        {
            Console.Clear();
            Console.WriteLine("Opção inválida");
            Thread.Sleep(2000);
            Console.Clear();
            calculadora();
        }

        /*
            Função de adição: pede 2 números para o usuário digitar e realiza a soma entre eles.
        */
        static void adicao()
        {
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número: ");
            int b = int.Parse(Console.ReadLine()!);
            int valor = a + b;
            Console.WriteLine($"A soma desses números é igual a: {valor}");
            aguardar();
        }

        /*
            Função de subtração: pede 2 números para o usuário digitar e realiza a subtração entre eles.
        */
        static void subtracao()
        {
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número: ");
            int b = int.Parse(Console.ReadLine()!);
            int valor = a - b;
            Console.WriteLine($"A subtração desses números é igual a: {valor}");
            aguardar();
        }

        /*
            Função de multiplicação: pede 2 números para o usuário digitar e realiza a multiplicação entre eles.
        */
        static void multiplicacao()
        {
            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número: ");
            int b = int.Parse(Console.ReadLine()!);
            int valor = a * b;
            Console.WriteLine($"A multiplicação desses números é igual a: {valor}");
            aguardar();
        }

        /*
            Função de divisão: pede 2 números para o usuário digitar e realiza a divisão entre eles.
        */
        static void divisao()
        {
            Console.Write("Digite um número: ");
            float a = float.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número: ");
            float b = float.Parse(Console.ReadLine()!);
            float valor = a / b;
            Console.WriteLine($"A divisão desses números é igual a: {valor:F2}");
            aguardar();
        }

        /*
            Função de porcentagem: pede 2 números para o usuário digitar e realiza a porcentegem entre eles.
        */
        static void porcentagem()
        {
            Console.Write("Digite um número: ");
            float a = float.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número: ");
            float b = float.Parse(Console.ReadLine()!);
            float valor = a * b / 100;
            Console.WriteLine($"{a}% de {b} é igual a: {valor}");
            aguardar();
        }

        /*
            Função de potência: pede 2 números para o usuário digitar e mostra o resultado do primeiro número elevado ao segundo número.
        */
        static void potencia()
        {
            Console.Write("Digite a base: ");
            double a = double.Parse(Console.ReadLine()!);
            Console.Write("Digite o expoente: ");
            double b = double.Parse(Console.ReadLine()!);
            double valor = Math.Pow(a, b);
            Console.WriteLine($"{a} elevado a {b} é igual a: {valor}");
            aguardar();
        }

        /*
            Função de aguardar: após mostrar o resultado da operação aparecerá uma mensagem ao usuário e é só clicar em alguma tecla para fechar o terminal.
        */
        static void aguardar()
        {
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
