using System;

namespace calculoRectangulho
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite a base :");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura :");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Calculadora calc = new Calculadora(baseRetangulo, alturaRetangulo);
            double area = calc.CalcularArea();
            double quadrado = calc.CalcularQuadrado();
            double triangulo = calc.CalcularTriangulo();
            double losango = calc.CalcularLosango();
            double paralelogramo = calc.CalcularParalelogramo();
            double trapezio = calc.CalcularTrapezio();
            double cubo = calc.CalcularCubo();
            double cilindro = calc.CalcularCilindro();
            double cone = calc.CalcularCone();
            double piramide = calc.CalcuraPiramide();
            double circulo = calc.CalcularCirculo();
            double esfera = calc.CaclularEsfera();


            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Resultados:");
            Console.WriteLine($"Área do retângulo: {area:F2}");
            Console.WriteLine($"Área do quadrado: {quadrado:F2}");
            Console.WriteLine($"Área do triângulo: {triangulo:F2}"); 
            Console.WriteLine($"Área do losango: {losango:F2}" );
            Console.WriteLine($"Área do paralelogramo: ${losango:F2}" );
            Console.WriteLine($"Área do trapezio: {trapezio:F2}" );
            Console.WriteLine($"Área do cubo: ${cubo:F2}");
            Console.WriteLine($"Área do cilindro: {cilindro:F2}" );
            Console.WriteLine($"Área do cone: ${cone:F2}");
            Console.WriteLine($"Área da piramide: {piramide:F2}" );
            Console.WriteLine($"Área do circulo: {circulo:F2}" );
            Console.WriteLine($"Área da esfera: {esfera:F2}" );
            

        }
    }
}