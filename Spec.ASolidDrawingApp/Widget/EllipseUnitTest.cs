using ASolidDrawingApp.Widget;

namespace Spec.ASolidDrawingApp.Widget
{
    public class EllipseUnitTest
    {
        [Theory]
        [InlineData(100, 150, 300, 200, "Ellipse (100,150) diameterH=300 diameterV=200")]
        public void Ellipse_should_render_correctly(int positionX, int positionY, int horizontalDiameter, int verticalDiameter, string expected)
        {
            // Arrange
            var ellipse = new EllipseWidget(positionX, positionY, horizontalDiameter, verticalDiameter);
            // Act
            var actual = ellipse.Draw();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, -1, 10)]
        [InlineData(0, 0, 10, -1)]
        public void Ellipse_should_throw_exception_when_either_diameter_is_negative(int positionX, int positionY, int horizontalDiameter, int verticalDiameter)
        {
            Assert.Throws<ArgumentException>(() => new EllipseWidget(positionX, positionY, horizontalDiameter, verticalDiameter));
        }
    }
}
