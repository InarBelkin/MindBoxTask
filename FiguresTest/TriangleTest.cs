using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary.MainFigures;
using Xunit;

namespace FiguresTest
{
    public class TriangleTest
    {
        public const int Tolerance = 5;

        [Fact]
        public void RightSidedArea()
        {
            Assert.Equal(0.5, new Triangle(1, 1, 1.41421356237).Area, Tolerance);
        }
        
        [Fact]
        public void AreaTest()
        {
            Assert.Equal(43.30127018922193, new Triangle(10, 10, 10).Area, Tolerance);
        }
        
        [Fact]
        public void AreaTest2()
        {
            Assert.Equal(8.181534085976786, new Triangle(4, 5, 8).Area, Tolerance);
        }

        [Fact]
        public void IsRightAngle()
        {
            Assert.True(new Triangle(1, 1, 1.41421356237).IsRightAngled);
        }

        [Fact]
        public void IsNotRightAngle()
        {
            Assert.False(new Triangle(1, 1, 1).IsRightAngled);
        }


        [Fact]
        public void WrongSidesLength()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }

        [Fact]
        public void IsSidesAppliedCreateByParams()
        {
            var sides = new double[] {1, 1, 1};
            var triangle = new Triangle(sides);
            Assert.Equal(sides, triangle.Sides);
        }

        [Fact]
        public void IsSidesApplied()
        {
            var sides = new double[] {1, 1, 1};
            var triangle = new Triangle(sides[0], sides[1], sides[2]);
            Assert.Equal(sides, triangle.Sides);
        }

        [Fact]
        public void WrongParamsLength()
        {
            var sides = new double[] {1, 1, 1, 1};
            Assert.Throws<ArgumentException>(() => new Triangle(sides));
        }
    }
}