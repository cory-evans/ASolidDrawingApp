using ASolidDrawingApp.Widget;

namespace Spec.ASolidDrawingApp.Widget
{
    public class RectangleUnitTest
    {
        [Theory]
        [InlineData(10, 10, 30, 40, "Rectangle (10,10) width=30 height=40")]
        public void Rectangle_should_render_correctly(int positionX, int positionY, int width, int height, string expected)
        {
            // Arrange
            var rectangle = new RectangleWidget(positionX, positionY, width, height);
            // Act
            var actual = rectangle.Draw();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, -1, 10)]
        [InlineData(0, 0, 10, -1)]
        public void Rectangle_should_throw_exception_when_width_or_height_is_negative(int positionX, int positionY, int width, int height)
        {
            Assert.Throws<ArgumentException>(() => new RectangleWidget(positionX, positionY, width, height));
        }
    }
}
