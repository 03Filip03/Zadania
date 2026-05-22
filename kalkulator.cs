using System;

class Kalkulator {
    static void Main() {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        double wynik = 0;
        switch (op) {
            case "+": wynik = a + b; break;
            case "-": wynik = a - b; break;
            case "*": wynik = a * b; break;
            case "/":
                if (b != 0) wynik = a / b;
                else { Console.WriteLine("Błąd: dzielenie przez zero!"); return; }
                break;
            default:
                Console.WriteLine("Nieznana operacja!"); return;
        }
        Console.WriteLine($"Wynik: {wynik}");
    }
}
