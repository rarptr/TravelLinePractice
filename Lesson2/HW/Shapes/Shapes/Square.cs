using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;
using Shapes.Utils;

namespace Shapes;

public class Square : IShape
{
    private readonly ShapeValidator _validator;
    private readonly double _sideLength;

    public double Side { get { return _sideLength; } }

    public Square(ShapeValidator validator, double sideLength)
    {
        _validator = validator;
        _validator.CheckSegmentLength(sideLength);

        _sideLength = sideLength;
    }

    public double CalculateArea() => Math.Pow(_sideLength, 2);

    public double CalculatePerimeter() => _sideLength * 4;
}
