namespace ASolidDrawingApp.Widget
{
    public class TextboxWidget : WidgetBase
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public string Text { get; protected set; }

        public TextboxWidget(int positionX, int positionY, int width, int height, string text)
            : base(positionX, positionY)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Width and height must be greater than or equal to 0");
            }

            Width = width;
            Height = height;
            Text = text;
        }

        public override string Draw()
        {
            return $"Textbox {Position} width={Width} height={Height} text=\"{Text}\"";
        }
    }
}
