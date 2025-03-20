using ASolidDrawingApp.Widget;

namespace Spec.ASolidDrawingApp.Widget
{
    public class SquareUnitTest
    {
        [Theory]
        [InlineData(10, 10, 35, "Square (10,10) size=35")]
        public void Square_should_render_correctly(int positionX, int positionY, int width, string expected)
        {
            // Arrange
            var square = new SquareWidget(positionX, positionY, width);
            // Act
            var actual = square.Draw();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, -1)]
        public void Square_should_throw_exception_when_diameter_is_negative(int positionX, int positionY, int diameter)
        {
            Assert.Throws<ArgumentException>(() => new SquareWidget(positionX, positionY, diameter));
        }
    }
}
