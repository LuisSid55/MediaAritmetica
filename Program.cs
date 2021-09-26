using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, x1, x2, x3;
            Console.WriteLine("\n--Média aritimética--");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nPara calcular a media, digite os 3 valores");
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPrimeiro número: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            
            Console.Write("Segundo número:  ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Terceiro número: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            media = (x1 + x2 + x3) / 3;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nMédia: {media:N1}\n");
            Console.ResetColor();
        }
    }
}
