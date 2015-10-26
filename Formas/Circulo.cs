using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do circulo com os valores informado pelo usuário
/// </summary>
    public class Circulo : Figura, IResultado
    {
        public void CalcularArea()
        {
            Circulo calculoCirculo = new Circulo();
            Console.WriteLine("Qual o raio do Circulo?");
            calculoCirculo.Raio = double.Parse(Console.ReadLine());
            double areaCirculo = (Math.PI * Math.Pow(calculoCirculo.Raio, 2));
            Console.WriteLine("A area do Circulo é de {0}", areaCirculo);
            Console.ReadKey();
        }
    }
}
