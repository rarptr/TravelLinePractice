using Shapes;
using Shapes.Utils;

namespace ShapeTests;

public class TriangleTests
{
    private TriangleValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new TriangleValidator();
    }

    [TestCase(-1, 0, 2)]
    [TestCase(0, -0.123, 10)]
    [TestCase(-100, 122, -1)]
    public void Triangle—onstructor_NotPositiveLengths_ArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(_validator, a, b, c));
    }

    [TestCase(10.2, 5.1, 5.1)]
    [TestCase(12, 5, 5)]
    [TestCase(0.01, 0.02, 1)]
    public void Triangle—onstructor_InvalidLengths_ArgumentException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(_validator, a, b, c));
    }

    [TestCase(2, 2, 1, 0.9682458365518543)]
    [TestCase(3, 4, 5, 6)]
    [TestCase(10.123, 6.534, 5.234, 15.061006234965376)]
    public void CalculateArea_ValidInput_CorrectAnswer(double a, double b, double c, double res)
    {
        var triangle = new Triangle(_validator, a, b, c);

        var area = triangle.CalculateArea();

        Assert.That(area, Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(2, 2, 1, 5)]
    [TestCase(3, 4, 5, 12)]
    [TestCase(10.123, 6.534, 5.234, 21.891)]
    public void CalculatePerimeter_ValidInput_CorrectAnswer(double a, double b, double c, double res)
    {
        var triangle = new Triangle(_validator, a, b, c);

        var perim = triangle.CalculatePerimeter();

        Assert.That(perim, Is.EqualTo(res).Within(0.0001));
    }
}