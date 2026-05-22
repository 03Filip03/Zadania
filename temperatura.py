kierunek = input("Wybierz kierunek konwersji (c = Celsius na Fahrenheit, f = Fahrenheit na Celsius): ")
temperatura = float(input("Podaj wartość temperatury: "))

if kierunek == "c":
    wynik = temperatura * 1.8 + 32
    print(f"Wynik: {temperatura}°C = {wynik}°F")
elif kierunek == "f":
    wynik = (temperatura - 32) / 1.8
    print(f"Wynik: {temperatura}°F = {wynik:.1f}°C")
else:
    print("Nieprawidłowy kierunek konwersji!")
