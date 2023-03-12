using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;
using Shapes.Utils;

namespace Shapes;

public class Triangle : IShape
{
    private readonly TriangleValidator _validator;
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;

    public double SideA { get { return _sideA; } }
    public double SideB { get { return _sideB; } }
    public double SideC { get { return _sideC; } }

    public Triangle(TriangleValidator validator, double sideA, double sideB, double sideC)
    {
        _validator = validator;
        _validator.CheckForExistence(sideA, sideB, sideC);

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CalculateArea() => HeronsFormula();

    public double CalculatePerimeter() => _sideA + _sideB + _sideC;

    private double HeronsFormula()
    {
        var p = CalculatePerimeter() / 2.0;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }
}
