namespace Aula41
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalculaArea()
        {
            double p = (A + B + C) / 2;

            double Area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return Area;
        }
    }
}
