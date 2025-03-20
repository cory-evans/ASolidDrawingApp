namespace ASolidDrawingApp.Widget
{
    public abstract class WidgetBase
    {
        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }

        protected WidgetBase(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }

        protected string Position => $"({PositionX},{PositionY})";

        public abstract string Draw();
    }
}
