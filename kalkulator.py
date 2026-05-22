a = float(input("Podaj pierwszą liczbę: "))
b = float(input("Podaj drugą liczbę: "))
operacja = input("Wybierz operację (+, -, *, /): ")

if operacja == "+":
    wynik = a + b
elif operacja == "-":
    wynik = a - b
elif operacja == "*":
    wynik = a * b
elif operacja == "/":
    if b != 0:
        wynik = a / b
    else:
        print("Błąd: dzielenie przez zero!")
        wynik = None
else:
    print("Nieznana operacja!")
    wynik = None

if wynik is not None:
    print(f"Wynik: {wynik}")
