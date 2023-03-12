using NUnit.Framework;
using Practic;

namespace Test
{
    public class StudentTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}     

        [TestCase(0)]
        [TestCase(10)]
        [TestCase(1000)]
        public void SetAge_ValidAge_NoException(int age)
        {
            // Arrange
            var p = new Student();

            // Act & Assert
            Assert.DoesNotThrow(() => p.Age = age);
        }

        [TestCase(-1)]
        [TestCase(-10)]
        public void SetAge_NegativeAge_NoException(int age)
        {
            // Arrange
            var p = new Student();

            // Act & Assert
            Assert.Throws<ArgumentException>(() => p.Age = age);
        }
    }
}