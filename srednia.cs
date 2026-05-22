using System;

class SredniaOcen {
    static void Main() {
        Console.Write("Podaj liczbę ocen: ");
        int n = int.Parse(Console.ReadLine());
        double suma = 0;

        for (int i = 1; i <= n; i++) {
            Console.Write($"Podaj ocenę {i}: ");
            suma += double.Parse(Console.ReadLine());
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}
