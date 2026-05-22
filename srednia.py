n = int(input("Podaj liczbę ocen: "))
oceny = []

for i in range(n):
    ocena = float(input(f"Podaj ocenę {i+1}: "))
    oceny.append(ocena)

srednia = sum(oceny) / len(oceny)
print(f"Średnia: {srednia:.2f}")

if srednia >= 3.0:
    print("Uczeń zdał.")
else:
    print("Uczeń nie zdał.")
