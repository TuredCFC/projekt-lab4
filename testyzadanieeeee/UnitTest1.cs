using System;
using Xunit;
namespace UnitTests
{
    public class QuadraticEquationTests
    {
        [Theory]
        [InlineData(1, -3, 2, 2, 1)]
        [InlineData(1, 0, -1, 1, -1)]
        [InlineData(2, -4, 2, 1, 2)]
        public void TestRealRoots(double a, double b, double c, double expectedRoot1, double expectedRoot2)
        {
            double root1, root2;
            int numberOfRoots = FindRoots(a, b, c, out root1, out root2); Assert.Equal(2, numberOfRoots);
            Assert.Equal(expectedRoot1, root1, (int)1e-6);
            Assert.Equal(expectedRoot2, root2, (int)1e-6);
        }
        [Theory]
        [InlineData(1, 2, 1)]
        [InlineData(2, 4, 2)]
        [InlineData(2, 2, 1)]
        public void TestOneRealRoot(double a, double b, double c)
        {
            double root1, root2;
            int numberOfRoots = FindRoots(a, b, c, out root1, out root2); Assert.Equal(1, numberOfRoots);
            Assert.Equal(-b / (2 * a), root1, (int)1e-6);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 4, 5)]
        public void TestNoRealRoots(double a, double b, double c)
        {
            double root1, root2;
            int numberOfRoots = FindRoots(a, b, c, out root1, out root2); Assert.Equal(0, numberOfRoots);
        }
        private int FindRoots(double a, double b, double c, out double root1, out double root2)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                root1 = root2 = 0;
                return 0;
            }
            if (discriminant == 0)
            {
                root1 = root2 = -b / (2 * a);
                return 1;
            }
            double sqrtDiscriminant = Math.Sqrt(discriminant);
            root1 = (-b + sqrtDiscriminant) / (2 * a);
            root2 = (-b - sqrtDiscriminant) / (2 * a);
            return 2;
        }
    }
}