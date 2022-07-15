using NUnit.Framework;
using System;
using TestTask;

namespace TestTask_Test
{
    public class Tests
    {

        [Test]
        public void ConstructTriangle1()
        {
            Assert.Throws<ArgumentException>(() => { Figure f = new Triangle(10, 4, 5); });
        }

        [Test]
        public void ConstructTriangle2()
        {
            Assert.Throws<ArgumentException>(() => { Figure f = new Triangle(1, 4, 30); });
        }

        [Test]
        public void ConstructTriangle3()
        {
            Assert.Throws<ArgumentException>(() => { Figure f = new Triangle(3, 4, -5); });
        }

        [Test]
        public void ConstructTriangle4()
        {
            Assert.DoesNotThrow(() => { Figure f = new Triangle(3, 4, 6); });
        }

        [Test]
        public void ConstructCircle1()
        {
            Assert.Throws<ArgumentException>(() => { Figure f = new Circle(-1); });
        }

        [Test]
        public void ConstructCircle2()
        {
            Assert.Throws<ArgumentException>(() => { Figure f = new Circle(0); });
        }

        [Test]
        public void ConstructCircle3()
        {
            Assert.DoesNotThrow(() => { Figure f = new Circle(10); });
        }

        [Test]
        public void RightTriangle1()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Test]
        public void RightTriangle2()
        {
            Triangle triangle = new Triangle(5, 4, 3);
            Assert.True(triangle.IsRightTriangle());
        }

        [Test]
        public void RightTriangle3()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            Assert.True(triangle.IsRightTriangle());
        }

        [Test]
        public void RightTriangle4()
        {
            Triangle triangle = new Triangle(5, 4, 5);
            Assert.False(triangle.IsRightTriangle());
        }

        [Test]
        public void TriangleArea1()
        {
            Figure f = new Triangle(3, 4, 5);
            double trueArea = 3 * 4 / 2;
            Assert.True((f.GetArea() - trueArea) < Triangle.eps);
        }

        [Test]
        public void TriangleArea2()
        {
            Figure f = new Triangle(5, 4, 3);
            double trueArea = 3 * 4 / 2;
            Assert.True((f.GetArea() - trueArea) < Triangle.eps);
        }

        [Test]
        public void TriangleArea3()
        {
            Figure f = new Triangle(10, 10, 10);
            double trueArea = 10 * 10 * Math.Sqrt(3) / 4;
            Assert.True((f.GetArea() - trueArea) < Triangle.eps);
        }

        [Test]
        public void CircleArea1()
        {
            Figure f = new Circle(1);
            double trueArea = Math.PI;
            Assert.True((f.GetArea() - trueArea) < Triangle.eps);
        }

        [Test]
        public void CircleArea2()
        {
            Figure f = new Circle(5);
            double trueArea = Math.PI * 5 * 5;
            Assert.True((f.GetArea() - trueArea) < Triangle.eps);
        }


    }
}