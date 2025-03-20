namespace ASolidDrawingApp.Widget
{
    public class SquareWidget : WidgetBase
    {
        public int Width { get; protected set; }
        public SquareWidget(int positionX, int positionY, int width) : base(positionX, positionY)
        {
            if (width < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }

            Width = width;
        }

        public override string Draw()
        {
            return $"Square {Position} size={Width}";
        }
    }
}
