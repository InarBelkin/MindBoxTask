using System;
using FigureLibrary.MainFigures;
using Xunit;

namespace FiguresTest;

public class CircleTest
{
    public const int Tolerance = 5;

    [Fact]
    public void TestArea()
    {
        Assert.Equal(Math.PI, new Circle(1).Area, Tolerance);
    }

    [Fact]
    public void TestArea2()
    {
        Assert.Equal(12.566370614359172, new Circle(2).Area, Tolerance);
    }
}