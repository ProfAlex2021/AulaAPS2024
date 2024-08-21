namespace AulaAPS
{
    public class Quadrado : FormaGeometrica
    {
        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }
        
        public override double CalcularArea()
        {
            /*return lado * lado;*/
            return System.Math.Pow(lado, 2);
        }

        public override double CalcularPerimetro()
        {
            return lado * 4;
        }

        public override string ToString()
        {
            return $"Quadrado ({lado})";
        }
    }
}
