using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculoRectangulho
{
    public class Calculadora
    {
        public double BaseRetangulo { get; set; }
        public double Altura { get; set; }

        public Calculadora(double baseRetangulo, double altura)
        {
            BaseRetangulo = baseRetangulo;
            Altura = altura;
        }
        public double CalcularArea()
        {
            return BaseRetangulo * Altura;
        }
        public double CalcularQuadrado()
        {
            return BaseRetangulo * BaseRetangulo;
        }
        public double CalcularTriangulo()
        {
            return (BaseRetangulo * Altura) / 2;
        }
        public double CalcularCirculo()
        {
            return Math.PI * (BaseRetangulo * BaseRetangulo);
        }
        public double CalcularTrapezio()
        {
            return ((BaseRetangulo + Altura ) * Altura) / 2;
        }
        public double CalcularLosango()
        {
            // double diagonal = Math.Sqrt((BaseRetangulo * BaseRetangulo) + (Altura * Altura));
            // return (diagonal * diagonal) / 2;
            return (BaseRetangulo * Altura) / 2;
        }
        public double CalcularParalelogramo()
        {
            return BaseRetangulo * Altura;
        }
        public double CaclularEsfera()
        {
            return 4 * Math.PI * (BaseRetangulo * BaseRetangulo);
        }
        public double CalcularCubo()
        {
            return   6 *(BaseRetangulo * BaseRetangulo);
        }
        public double CalcularCilindro()
        {
            return 2 * Math.PI * (BaseRetangulo * BaseRetangulo) * Altura;
        }
        public double CalcularCone()
        {
            return Math.PI * (BaseRetangulo * BaseRetangulo) * Altura;
        }
        public double CalcuraPiramide()
        {
            return ((BaseRetangulo * BaseRetangulo) + 2 * BaseRetangulo * Math.Pow(Altura, 8));
        }
    }
}