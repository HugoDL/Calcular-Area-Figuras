using CalcularFormasPOO.Formas;
using System;

namespace CalcularFormasPOO
{/// <summary>
/// A classe Program é composta com os objetos usados e o método que o usuário terá para interagir com o "programa"
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            Quadrado quadrado = new Quadrado();
            Circulo circulo = new Circulo();
            Retangulo retangulo = new Retangulo();
            Losango losango = new Losango();
            Paralelogramo paralelogramo = new Paralelogramo();
            Trapezio trapezio = new Trapezio();
            Conjuntos conjunto = new Conjuntos();

            Figura[] figuras = new Figura[7];
            figuras[0] = triangulo;
            figuras[1] = quadrado;
            figuras[2] = circulo;
            figuras[3] = retangulo;
            figuras[4] = losango;
            figuras[5] = paralelogramo;
            figuras[6] = trapezio;

            int obj = 0;

            Console.WriteLine("Escolha o objeto: ");
            Console.WriteLine("1 para triangulo \n 2 para quadrado \n");
            Console.WriteLine("2 para quadrado");
            Console.WriteLine("3 para circulo");
            Console.WriteLine("4 para retangulo");
            Console.WriteLine("5 para losango");
            Console.WriteLine("6 para paralelogramo");
            Console.WriteLine("7 para trapézio");
            obj = int.Parse(Console.ReadLine());
            Console.WriteLine();


            switch (obj)
            {
                case 1:
                    conjunto.Adicionar(triangulo);
                    Console.WriteLine();
                    break;

                case 2:
                    conjunto.Adicionar(quadrado);
                    Console.WriteLine();
                    break;

                case 3:
                    conjunto.Adicionar(circulo);
                    Console.WriteLine();
                    break;

                case 4:
                    conjunto.Adicionar(retangulo);
                    Console.WriteLine();
                    break;

                case 5:
                    conjunto.Adicionar(losango);
                    Console.WriteLine();
                    break;

                case 6:
                    conjunto.Adicionar(paralelogramo);
                    Console.WriteLine();
                    break;

                case 7:
                    conjunto.Adicionar(trapezio);
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Err0r");
                    break;
            }
        }
    }
}
