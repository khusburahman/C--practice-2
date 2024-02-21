

namespace xm_practice;
 class Circle:Shape
{
    public double r;
    public override double CalculateArea()
    {
        return Math.PI * r * r;
    }
}
