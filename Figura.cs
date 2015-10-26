namespace CalcularFormasPOO
{/// <summary>
/// Nessa classe abstrata, fica as "medidas" que serão usadas para o cálculo das figuras geométricas
/// </summary>
    public abstract class Figura
    {
        public double BaseObjeto { get; set; }
        public double Altura { get; set; }
        public double Raio { get; set; }
        public double DiagonalMaior { get; set; }
        public double DiagonalMenor { get; set; }
        public double BaseMaior { get; set; }
        public double BaseMenor { get; set; }
        public double _resultado = 0;
        public double Resultado
        {
            get { return this._resultado; }
            set
            {
                if (value >= 0)
                {
                    this._resultado = value;
                }
                else
                {
                    this._resultado = 0;
                }
            }
        }
    }
}
