public static class Exercicio6
{
    public static void Executar()
    {
        string diaSemana = "Quinta-feira";
        string temperatura = "31";
        string hora = "15";

        Console.Write("Que dia da semana é hoje? ");
        diaSemana = (Console.ReadLine()!);

        Console.Write("Qual a temperatura agora (em °C)? ");
        temperatura =Console.ReadLine()!;

        Console.Write("Que horas são agora? ");
        hora = Console.ReadLine()!;

        Console.WriteLine();
        // Desse momento em diante, toda vez que vamos mostrar o valor de uma variável e tem um texto,
        // dentro do Console.WriteLine, vamos iniciar com $, conforme exemplo abaixo
        Console.WriteLine($"Hoje é {diaSemana}, está fazendo {temperatura} °C e agora são {hora} horas.");

    }
}