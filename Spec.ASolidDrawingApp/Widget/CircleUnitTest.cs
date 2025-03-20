using ASolidDrawingApp.Widget;

namespace Spec.ASolidDrawingApp.Widget
{
    public class CircleUnitTest
    {
        [Theory]
        [InlineData(10, 10, 300, "Circle (10,10) size=300")]
        public void Circle_should_render_correctly(int positionX, int positionY, int diameter, string expected)
        {
            // Arrange
            var circle = new CircleWidget(positionX, positionY, diameter);
            // Act
            var actual = circle.Draw();
            // Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0, 0, -1)]
        public void Circle_should_throw_exception_when_diameter_is_negative(int positionX, int positionY, int diameter)
        {
            Assert.Throws<ArgumentException>(() => new CircleWidget(positionX, positionY, diameter));
        }
    }
}
