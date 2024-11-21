print('Ola Mundo') #printando Ola mundo
print('\n')#pulando linha
x = input('Digite o seu nome: ')#pedindo um input ao usuario
print('\n')#pulando linha
print(x)#printando a saida do input
x = 5#defindo uma variavel
print('\n')#pulando linha
print(x)#printando a variavel
print('\n')#pulando linha
y = 10# defindo outra variavel
print(x + y)#printando a soma das variaveis
print('\n')#pulando linha
def eh_par(numero):#definindo uma funcao
    return numero % 2 == 0#retornando se o numero eh par
numero = int(input('Digite um numero: '))#pedindo um input ao usuario
print('\n')#pulando linha
if(eh_par(numero)):#verificando se o numero eh par
    print('Par')#printando Par
else:#caso contrario
    print('Impar')#printando Impar

