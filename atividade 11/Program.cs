//declaracao de variavel

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Ano atual:");
        int anoAtual = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ano de nascimento: ");
        int anoNascimento = int.Parse(Console.ReadLine() ?? "0");

        int idade = anoAtual - anoNascimento;

        if (idade < 16)
            Console.WriteLine("Nao vota.");
        else if (idade >=16)
            Console.WriteLine("Voto facultativo.");
        else if (idade >= 18 && idade <= 69)
            Console.WriteLine("RVoto obrigatorio");
        else // idade >=70
            Console.WriteLine();
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}