using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("⚔️ Calculadora de Nível do Herói ⚔️");

        Console.WriteLine("------------------------- ");

        int vitorias = ReadInt("Numero de Vitórias: ");
        int derrotas = ReadInt("Número de Derrotas: ");

        Console.WriteLine(" --------------------------- ");

        int saldoVitorias = vitorias - derrotas;

        string nivel;

        if (saldoVitorias < 10)
        {
            nivel = "Ferro";
        }

        else if(saldoVitorias>=10 && saldoVitorias <=20)
        {  nivel = "Bronze";}

        else if (saldoVitorias >=21 && saldoVitorias <=50){
            nivel = "Prata";
        }

        else if (saldoVitorias >= 51 && saldoVitorias <= 80){
            nivel = "Ouro";
        }

        else if( saldoVitorias >= 81 && saldoVitorias <= 90){
            nivel = "Diamante";
        }

        else if (saldoVitorias >= 91 && saldoVitorias <= 100){
            nivel ="Lendário";
        }

        else {
            nivel ="Imortal";
        }

        Console.WriteLine($"O Herói tem um saldo de { saldoVitorias } vitórias e esta no nivel **{nivel}**");
    }

    static int ReadInt(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var value))
                return value;
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro:");
        }
    }
}




