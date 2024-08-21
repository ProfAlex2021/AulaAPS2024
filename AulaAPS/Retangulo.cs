

namespace AulaAPS
{
    internal class Retangulo : FormaGeometrica
    {
        private double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }

        private double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public override double CalcularArea()
        {
            return (_base * altura);
        }

        public override double CalcularPerimetro()
        {
            return ((_base * 2) + (altura * 2));
        }
    }
}
