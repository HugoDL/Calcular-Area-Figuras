using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do paralelogramo com os valores informado pelo usuário
/// </summary>
    public class Paralelogramo : Figura, IResultado
    {
        public void CalcularArea()
        {
            Paralelogramo calculoParalelogramo = new Paralelogramo();
            Console.WriteLine("Qual a base do Paralelogramo?");
            calculoParalelogramo.BaseObjeto = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do Paralelogramo?");
            calculoParalelogramo.Altura = double.Parse(Console.ReadLine());
            double areaParalelogramo = calculoParalelogramo.BaseObjeto * calculoParalelogramo.Altura;
            Console.WriteLine("A area do Paralelogramo é de {0}", areaParalelogramo);
            Console.ReadKey();
        }
    }
}
