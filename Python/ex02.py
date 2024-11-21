x = float(input("Digite a sua altura: "))
y = int(input("Digite o seu peso: "))
sexo = input("Digite o seu sexo: ")

if(sexo == "masculino"):
    imc = float(y) / (float(x) ** 2)
    print(f"O seu imc é: {imc:.2f}")
elif(sexo == "feminino"):
    imc = float(y) / (float(x) ** 2)
    print(f"O seu imc é: {imc:.2f}")
else:
    print("Sexo inválido")