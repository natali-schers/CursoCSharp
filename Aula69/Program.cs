internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escolha o tamanho do vetor: ");
        int n = int.Parse(Console.ReadLine());

        double[] vetor = new double[n];
        double soma = 0.0;

        Console.WriteLine("");
        Console.WriteLine("Digite os valores do vetor: ");
        for (int i = 0; i < n; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
            soma += vetor[i];
        }

        double media = soma/ n;

        Console.WriteLine("");
        Console.WriteLine("A média dos valores é: " + media.ToString("F2"));
    }
}