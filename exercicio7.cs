// -- Arquivo Exercicio7.cs
public static class Exercicio7
{
    public static void Executar()
    {
        double notaProva = 0;
        double notaAtividades = 0;
        double mediaFinal = 0;

        Console.Write("Digite a nota da prova: ");
        notaProva = double.Parse(Console.ReadLine ()!);

        Console.Write("Digite a nota das atividades em sala:");
        notaAtividades = double.Parse(Console.ReadLine ()!);

        mediaFinal = notaProva * 4 + notaAtividades * 6 / 10; 

        Console.WriteLine();
        Console.WriteLine($"A média final do aluno é: {mediaFinal}");
    }
}