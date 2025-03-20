using ASolidDrawingApp.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spec.ASolidDrawingApp.Widget
{
    public class TextBoxUnitTest
    {
        [Theory]
        [InlineData(5, 5, 200, 100, "sample text", "Textbox (5,5) width=200 height=100 text=\"sample text\"")]
        public void TextBox_should_render_correctly(int positionX, int positionY, int width, int height, string text, string expected)
        {
            // Arrange
            var textBox = new TextboxWidget(positionX, positionY, width, height, text);
            // Act
            var actual = textBox.Draw();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 0, -1, 10, "sample text")]
        [InlineData(0, 0, 10, -1, "sample text")]
        public void TextBox_should_throw_exception_when_width_or_height_is_negative(int positionX, int positionY, int width, int height, string text)
        {
            Assert.Throws<ArgumentException>(() => new TextboxWidget(positionX, positionY, width, height, text));
        }
    }
}
