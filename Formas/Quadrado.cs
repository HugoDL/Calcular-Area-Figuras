using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do quadrado com os valores informado pelo usuário
/// </summary>
    public class Quadrado : Figura, IResultado
    {
        public void CalcularArea()
        {
            Quadrado calculoQuadrado = new Quadrado();
            Console.WriteLine("Qual a altura do quadrado?");
            calculoQuadrado.Altura = double.Parse(Console.ReadLine());
            double areaQuadrado = calculoQuadrado.Altura * calculoQuadrado.Altura;
            Console.WriteLine("A area do quadrado é de {0}", areaQuadrado);
            Console.ReadKey();
        }
    }
}
