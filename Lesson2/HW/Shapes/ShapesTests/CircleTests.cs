using Shapes;
using Shapes.Utils;

namespace ShapeTests;

public class CircleTests
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
    public void Circle—onstructor_NotPositiveLength_ArgumentException(double radius)
    {
        Assert.Throws<ArgumentException>(() => new Circle(_validator, radius));
    }

    [TestCase(0.001, 0.000003)]
    [TestCase(1.25, 4.908739)]
    [TestCase(10_000, 314159265.358979)]
    public void CalculateArea_ValidInput_CorrectAnswer(double r, double res)
    {
        var circle = new Circle(_validator, r);

        var area = circle.CalculateArea();

        Assert.That(area, Is.EqualTo(res).Within(0.0001));
    }

    [TestCase(0.001, 0.00628)]
    [TestCase(1.25, 7.85398)]
    [TestCase(10_000, 62831.85307)]
    public void CalculatePerimeter_ValidInput_CorrectAnswer(double r, double res)
    {
        var circle = new Circle(_validator, r);

        var perim = circle.CalculatePerimeter();

        Assert.That(perim, Is.EqualTo(res).Within(0.0001));
    }
}