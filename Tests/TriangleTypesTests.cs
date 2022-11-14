using NUnit.Framework;
using TriangleTypes;

namespace Challenges.Tests
{
    [TestFixture]
    public class TriangleTypesTests
    {
        [Test]
        public void DeveSerTrianguloEquilatero()
        {
            Triangle equilateral = new(3, 3, 3);

            string result = equilateral.Validate();

            Assert.AreEqual("Equilateral Triangle", result);
        }

        [Test]
        public void DeveSerTrianguloIsoceles()
        {
            Triangle isosceles = new(3, 3, 1);

            string result = isosceles.Validate();

            Assert.AreEqual("Isosceles Triangle", result);
        }

        [Test]
        public void DeveSerTrianguloEscaleno()
        {
            Triangle scalene = new(4, 3, 2);

            string result = scalene.Validate();

            Assert.AreEqual("Scalene Triangle", result);
        }


        [Test]
        public void DeveSerTrianguloInvalido()
        {
            Triangle invalid = new(3, 2, 1);

            string result = invalid.Validate();

            Assert.AreEqual("Invalid Triangle", result);
        }
    }
}
