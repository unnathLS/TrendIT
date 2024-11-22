using System;

namespace calculadoraTest 
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int resultadoInteiro =  calc.Somar( 3 ,5);
            double resultadoDouble = calc.Somar( 3.5 , 5.7); 
            Console.WriteLine($"Inteiro: {resultadoInteiro} - Double: {resultadoDouble}");
        }
    }
}


