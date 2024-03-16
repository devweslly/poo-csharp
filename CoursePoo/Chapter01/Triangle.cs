namespace Chapter01
{
    public class Triangle
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public double CalculateArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            
            // Heron's formula
            double area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));

            return area;
        }
    }
}
