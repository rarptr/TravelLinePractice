using Shapes;
using Shapes.Utils;
using System.ComponentModel.DataAnnotations;

namespace ShapeTests;

public class SquareTests
{
    private ShapeValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new ShapeValidator();
    }

    [TestCase(0)]
    [TestCase(-0.123)]
    [TestCase(-100)]
    public void SquareConstructor_NotPositiveLength_ArgumentException(double sideLength)
    {
        Assert.Throws<ArgumentException>(() => new Square(_validator, sideLength));
    }

    [TestCase(0.001, 0.000001)]
    [TestCase(1.25, 1.5625)]
    [TestCase(10_000, 100_000_000)]
    public void CalculateArea_ValidInput_CorrectAnswer(double r, double res)
    {
        var square = new Square(_validator, r);

        var area = square.CalculateArea();

        Assert.That(area, Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(0.001, 0.004)]
    [TestCase(1.25, 5)]
    [TestCase(10_000, 40_000)]
    public void CalculatePerimeter_ValidInput_CorrectAnswer(double r, double res)
    {
        var square = new Square(_validator, r);

        var perim = square.CalculatePerimeter();

        Assert.That(perim, Is.EqualTo(res).Within(0.0001));
    }
}