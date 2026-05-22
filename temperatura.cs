using System;

class Konwerter {
    static void Main() {
        Console.Write("Wybierz kierunek (c = Celsius->Fahrenheit, f = Fahrenheit->Celsius): ");
        string kierunek = Console.ReadLine();
        Console.Write("Podaj wartość temperatury: ");
        double temp = double.Parse(Console.ReadLine());

        if (kierunek == "c") {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"Wynik: {temp}°C = {wynik}°F");
        } else if (kierunek == "f") {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"Wynik: {temp}°F = {wynik:F1}°C");
        } else {
            Console.WriteLine("Nieprawidłowy kierunek konwersji!");
        }
    }
}
