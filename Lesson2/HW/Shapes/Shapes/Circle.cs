using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;
using Shapes.Utils;

namespace Shapes;

public class Circle : IShape
{
    private readonly ShapeValidator _validator;
    private readonly double _radius;

    public Circle(ShapeValidator validator, double radius)
    {
        _validator = validator;
        _validator.CheckSegmentLength(radius);

        _radius = radius;
    }

    public double CalculateArea() => Math.PI * Math.Pow(_radius, 2);

    public double CalculatePerimeter() => 2 * Math.PI * _radius;
}
