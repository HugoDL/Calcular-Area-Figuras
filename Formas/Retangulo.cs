using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do retangulo com os valores informado pelo usuário
/// </summary>
    public class Retangulo : Figura, IResultado
    {
        public void CalcularArea()
        {
            Retangulo calculoRetangulo = new Retangulo();
            Console.WriteLine("Qual a base do Retangulo?");
            calculoRetangulo.BaseObjeto = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do Retangulo?");
            calculoRetangulo.Altura = double.Parse(Console.ReadLine());
            double areaRetangulo = calculoRetangulo.BaseObjeto * calculoRetangulo.Altura;
            Console.WriteLine("A area do Retangulo é de {0}", areaRetangulo);
            Console.ReadKey();
        }
    }
}
