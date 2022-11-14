namespace TriangleTypes
{
    public class Triangle
    {
        private double SideA = 0, SideB = 0, SideC = 0;

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public string Validate()
        {
            if (IsValid())
            {
                if (IsEquilateral())
                    return "Equilateral Triangle";
                else if (IsIsosceles())
                    return "Isosceles Triangle";
                else
                    return "Scalene Triangle";
            }
            else
                return "Invalid Triangle";
        }

        private bool IsEquilateral()
        {
            return SideA == SideB && SideA == SideC;
        }

        private bool IsIsosceles()
        {
            return SideA == SideB || SideA == SideC || SideB == SideC;
        }

        private bool IsValid()
        {
            return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
        }
    }
}
