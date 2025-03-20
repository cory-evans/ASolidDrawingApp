namespace ASolidDrawingApp.Widget
{
    public class RectangleWidget : WidgetBase
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }

        public RectangleWidget(int positionX, int positionY, int width, int height)
            : base(positionX, positionY)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Width and height must be greater than or equal to 0");
            }

            Width = width;
            Height = height;
        }

        public override string Draw()
        {
            return $"Rectangle {Position} width={Width} height={Height}";
        }
    }
}
