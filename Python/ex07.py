ALUNOS = {
    21: ["Ana","1.7"],
    14: ["Carlos","1.82"],
    37: ["Priscila","1.63"],
    91: ["Maria Eduarda","1.68"],
    46: ["Henrique","1.57"]
}

for dados in ALUNOS.values():
    print(dados)
print('\n')

ALUNOS.pop(21)
ALUNOS.pop(37)
print(len(ALUNOS))
