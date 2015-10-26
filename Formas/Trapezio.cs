using System;

namespace CalcularFormasPOO.Formas
{/// <summary>
/// Aqui será feito o calculo do trapezio com os valores informado pelo usuário
/// </summary>
    public class Trapezio : Figura, IResultado
    {
        public void CalcularArea()
        {
            Trapezio calculoTrapezio = new Trapezio();
            Console.WriteLine("Qual a base Maior do Trapezio?");
            calculoTrapezio.BaseMaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a base Menor do Trapezio?");
            calculoTrapezio.BaseMenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do Paralelogramo?");
            calculoTrapezio.Altura = double.Parse(Console.ReadLine());
            double baseTrapezio = calculoTrapezio.BaseMenor + calculoTrapezio.BaseMaior;
            double areaTrapezio = (baseTrapezio * calculoTrapezio.Altura) / 2;
            Console.WriteLine("A area do Trapezio é de {0}", areaTrapezio);
            Console.ReadKey();
        }
    }
}

