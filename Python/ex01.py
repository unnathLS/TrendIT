salario = float(input("Digite o salario: "))
cargo = input("Digite o cargo: ")

if(cargo == "programador"):
    print(f"O novo salario e: {salario + (salario * 0.5)}")
elif(cargo == "analista de sistemas"):
    print(f"O novo salario e: {salario + (salario * 0.4)}")
elif(cargo == "analista de banco de dados"):
    print(f"O novo salario e: {salario + (salario * 0.3)}")
else:
    print("Cargo não encontrado")