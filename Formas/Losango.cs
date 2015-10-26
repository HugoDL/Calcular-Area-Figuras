using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do losango com os valores informado pelo usuário
/// </summary>
    public class Losango : Figura, IResultado
    {
        public void CalcularArea()
        {
            Losango calculoLosango = new Losango();
            Console.WriteLine("Qual a diagonal Maior do Losango?");
            calculoLosango.DiagonalMaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a diagonal Menor do Retangulo?");
            calculoLosango.DiagonalMenor = double.Parse(Console.ReadLine());
            double areaLosango = (calculoLosango.DiagonalMaior * calculoLosango.DiagonalMenor) / 2;
            Console.WriteLine("A area do Losango é de {0}", areaLosango);
            Console.ReadKey();
        }
    }   
}
