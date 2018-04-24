using Xunit;
using FigureLibrary;


namespace Figure.Tests
{
    public class FigureTest
    {
        [Fact]
        public void Can_Area_Circle()
        {
            //arrange
            IFigure circle = new Circle(10);
            double circleArea = 0;
            //act
            circleArea = circle.GetArea();
            //assert
            Assert.Equal(314, (int)circleArea);
        }

        [Fact]
        public void Can_Area_Triangle()
        {
            //arrange
            IFigure triangle = new Triangle(3,4,5);
            double triangleArea = 0;
            //act
            triangleArea = triangle.GetArea();
            //assert
            Assert.Equal(6, triangleArea);
        }
    }
}
