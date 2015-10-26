using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do triangulo com os valores informado pelo usuário
/// </summary>
    public class Triangulo : Figura, IResultado
    {
        public void CalcularArea()
        {
            Triangulo calculoTriangulo = new Triangulo();
            Console.WriteLine("Qual a base do triangulo?");
            calculoTriangulo.BaseObjeto = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do triangulo?");
            calculoTriangulo.Altura = double.Parse(Console.ReadLine());
            double areaTriangulo = (calculoTriangulo.BaseObjeto * calculoTriangulo.Altura) / 2;
            Console.WriteLine("A area do triangulo é de {0}", areaTriangulo);
            Console.ReadKey();
        }
    }
}
